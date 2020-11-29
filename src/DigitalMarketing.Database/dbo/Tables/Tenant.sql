CREATE TABLE [dbo].[Tenant] (
    [Id]    UNIQUEIDENTIFIER DEFAULT (newsequentialid()) NOT NULL,
    [Label] NVARCHAR (150)   NOT NULL,
    [Name]  NVARCHAR (150)   NOT NULL,
    CONSTRAINT [PK_Tenant] PRIMARY KEY CLUSTERED ([Id] ASC)
);

