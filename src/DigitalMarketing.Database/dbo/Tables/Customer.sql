CREATE TABLE [dbo].[Customer] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [TenantId] UNIQUEIDENTIFIER NOT NULL,
    [Name]     NVARCHAR (50)    NOT NULL,
    [Email]    NVARCHAR (150)   NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customer_Tenant] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[Tenant] ([Id])
);

