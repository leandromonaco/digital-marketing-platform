﻿/*
Deployment script for DigitalMarketing

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DigitalMarketing"
:setvar DefaultFilePrefix "DigitalMarketing"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                DATE_CORRELATION_OPTIMIZATION OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET TEMPORAL_HISTORY_RETENTION ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Creating [dbo].[Snapshot]...';


GO
CREATE TABLE [dbo].[Snapshot] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [TenantId]  UNIQUEIDENTIFIER NULL,
    [Timestamp] DATETIME         NOT NULL,
    [Type]      SMALLINT         NOT NULL,
    [Content]   NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_Snapshot_1] PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[Lead]...';


GO
CREATE TABLE [dbo].[Lead] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [TenantId]         UNIQUEIDENTIFIER NOT NULL,
    [FullName]         NVARCHAR (150)   NOT NULL,
    [Email]            NVARCHAR (150)   NOT NULL,
    [RegistrationDate] DATETIME         NOT NULL,
    CONSTRAINT [PK_Lead] PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[Campaign]...';


GO
CREATE TABLE [dbo].[Campaign] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [TenantId] UNIQUEIDENTIFIER NOT NULL,
    [Name]     NVARCHAR (150)   NOT NULL,
    CONSTRAINT [PK_Campaign] PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[Tenant]...';


GO
CREATE TABLE [dbo].[Tenant] (
    [Id]       UNIQUEIDENTIFIER NOT NULL,
    [Domain]   NVARCHAR (150)   NOT NULL,
    [Name]     NVARCHAR (150)   NOT NULL,
    [Settings] NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_Tenant] PRIMARY KEY CLUSTERED ([Id] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating unnamed constraint on [dbo].[Snapshot]...';


GO
ALTER TABLE [dbo].[Snapshot]
    ADD DEFAULT (newsequentialid()) FOR [Id];


GO
PRINT N'Creating unnamed constraint on [dbo].[Lead]...';


GO
ALTER TABLE [dbo].[Lead]
    ADD DEFAULT (newsequentialid()) FOR [Id];


GO
PRINT N'Creating unnamed constraint on [dbo].[Campaign]...';


GO
ALTER TABLE [dbo].[Campaign]
    ADD DEFAULT (newsequentialid()) FOR [Id];


GO
PRINT N'Creating unnamed constraint on [dbo].[Tenant]...';


GO
ALTER TABLE [dbo].[Tenant]
    ADD DEFAULT (newsequentialid()) FOR [Id];


GO
PRINT N'Creating [dbo].[FK_Lead_Tenant]...';


GO
ALTER TABLE [dbo].[Lead]
    ADD CONSTRAINT [FK_Lead_Tenant] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[Tenant] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Campaign_Tenant]...';


GO
ALTER TABLE [dbo].[Campaign]
    ADD CONSTRAINT [FK_Campaign_Tenant] FOREIGN KEY ([TenantId]) REFERENCES [dbo].[Tenant] ([Id]);


GO
INSERT [dbo].[Tenant] ([Id], [Domain], [Name], [Settings]) VALUES (N'e5c7ee9a-28a2-ea11-8358-a44cc80abe07', N'softwareworker.com', N'Software Worker', N'')
INSERT [dbo].[Tenant] ([Id], [Domain], [Name], [Settings]) VALUES (N'6e2b3484-40a2-ea11-8358-a44cc80abe07', N'arystec.com', N'Arystec', N'{ "Components": { "Cover": { "Title": "Ingeniería y Construcciones", "SubTitle": "Mas de 20 años de experiencia", "Paragraph": "Asesoramiento integral en la industria petroquímica.", "BackgroundImage": "tenants/arystec/images/arystec-cover.jpg", "BackgroundVideo": "", "ButtonText": "Descargar Brochure", "DownloadFile": "tenants/arystec/download/Arystec_brochure.pdf" }, "CallToAction": { "Title": "Calidad y Profesionalismo", "Paragraph": " Obras Técnicamente Confiables y Operativamente Seguras", "ButtonText": "Descargar Brochure", "DownloadFile": "tenants/arystec/download/Arystec_brochure.pdf" }, "Carrousel": { "Title": "Certificaciones", "Images": [ "tenants/arystec/images/carrousel/iqnet.png", "tenants/arystec/images/carrousel/iso14001.png", "tenants/arystec/images/carrousel/siclar.png", "tenants/arystec/images/carrousel/iso9001.png", "tenants/arystec/images/carrousel/rina.png" ] }, "Gallery": { "Title": "Trabajos", "Paragraph": " La experiencia nacional e internacional de nuestro staff asegura la finalización exitosa de los trabajos encomendados, cumpliendo con la legislación vigente y minimizando los costos de ejecución.", "images": [ "tenants/arystec/images/gallery/Trabajos_1.jpg", "tenants/arystec/images/gallery/Trabajos_2.jpg", "tenants/arystec/images/gallery/Trabajos_3.jpg", "tenants/arystec/images/gallery/Trabajos_4.jpg", "tenants/arystec/images/gallery/Trabajos_5.jpg", "tenants/arystec/images/gallery/Trabajos_6.jpg", "tenants/arystec/images/gallery/Trabajos_7.jpg", "tenants/arystec/images/gallery/Trabajos_8.jpg", "tenants/arystec/images/gallery/Trabajos_9.jpg", "tenants/arystec/images/gallery/Trabajos_10.jpg", "tenants/arystec/images/gallery/Trabajos_11.jpg", "tenants/arystec/images/gallery/Trabajos_12.jpg" ] }, "ContactForm": { "Key": "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", "AuthorizedSenderEmail": "admin@arystec.com", "Map": "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3280.5855110387743!2d-58.397048784172895!3d-34.69040916959841!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x95bccce80362246f%3A0x8c6c46499d08cba0!2sConcejal%20H.%20Noya%201247%2C%20B1824DXH%20Lan%C3%BAs%20Oeste%2C%20Buenos%20Aires%2C%20Argentina!5e0!3m2!1sen!2sus!4v1589769470962!5m2!1sen!2sus", } } }')
INSERT [dbo].[Tenant] ([Id], [Domain], [Name], [Settings]) VALUES (N'a403fd8c-40a2-ea11-8358-a44cc80abe07', N'protechexteriors.co.nz', N'Pro Tech Exteriors', N'')
INSERT [dbo].[Tenant] ([Id], [Domain], [Name], [Settings]) VALUES (N'b441b19c-40a2-ea11-8358-a44cc80abe07', N'aiswalker.com', N'AIS Walker', N'')
GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
