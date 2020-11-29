using System;
using System.Collections.Generic;

namespace DigitalMarketing.Model.Database
{
    public partial class Tenant
    {
        public Tenant()
        {
            Customer = new HashSet<Customer>();
            Product = new HashSet<Product>();
            TenantConfiguration = new HashSet<TenantConfiguration>();
        }

        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<TenantConfiguration> TenantConfiguration { get; set; }
    }
}
