CREATE TABLE [dbo].[TenantConfiguration] (
    [TenantId] UNIQUEIDENTIFIER NOT NULL,
    [FileId]   UNIQUEIDENTIFIER NOT NULL,
    [Content]  NTEXT            NOT NULL,
    [LastModified] DATETIME NOT NULL, 
    CONSTRAINT [PK_TenantConfiguration_1] PRIMARY KEY CLUSTERED ([TenantId] ASC, [FileId] ASC),
    CONSTRAINT [FK_TenantConfiguration_Tenant] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[Tenant] ([Id]),
    CONSTRAINT [FK_TenantConfiguration_TenantFile] FOREIGN KEY ([FileId]) REFERENCES [dbo].[ConfigurationFile] ([Id])
);

