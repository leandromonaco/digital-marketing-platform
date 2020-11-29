CREATE TABLE [dbo].[Product] (
    [Id]       UNIQUEIDENTIFIER CONSTRAINT [DF_Product_Id] DEFAULT (newsequentialid()) NOT NULL,
    [Name]     NVARCHAR (300)   NOT NULL,
    [TenantId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Product_Tenant] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[Tenant] ([Id])
);

