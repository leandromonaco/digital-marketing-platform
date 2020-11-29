CREATE TABLE [dbo].[ConfigurationFile] (
    [Id]       UNIQUEIDENTIFIER CONSTRAINT [DF_TenantFiles_Id] DEFAULT (newsequentialid()) NOT NULL,
    [Filename] NVARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_TenantConfiguration] PRIMARY KEY CLUSTERED ([Id] ASC)
);

