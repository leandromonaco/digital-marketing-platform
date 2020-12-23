using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace DigitalMarketing.Core.Database
{
    public partial class DigitalMarketingContext : DbContext
    {
        IConfiguration _configuration;
        public DigitalMarketingContext()
        {
        }

        public DigitalMarketingContext(DbContextOptions<DigitalMarketingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConfigurationFile> ConfigurationFile { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Tenant> Tenant { get; set; }
        public virtual DbSet<TenantConfiguration> TenantConfiguration { get; set; }
        public virtual DbSet<Touchpoint> Touchpoint { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
               .SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddUserSecrets("cf9af699-d3c2-4090-8231-fd3a1cb45a5f")
               .AddEnvironmentVariables();


                _configuration = builder.Build();
                //See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DigitalMarketingDatabase"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfigurationFile>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Tenant");
            });


            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TenantConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.TenantId, e.FileId })
                    .HasName("PK_TenantConfiguration_1");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.TenantConfiguration)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantConfiguration_TenantFile");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantConfiguration)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantConfiguration_Tenant");
            });

            modelBuilder.Entity<Touchpoint>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Touchpoint)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Touchpoint_Customer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
