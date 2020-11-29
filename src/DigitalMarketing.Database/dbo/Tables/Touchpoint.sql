CREATE TABLE [dbo].[Touchpoint] (
    [Id]          UNIQUEIDENTIFIER CONSTRAINT [DF__Lead__Id__2A4B4B5E] DEFAULT (newsequentialid()) NOT NULL,
    [CustomerId]  UNIQUEIDENTIFIER NOT NULL,
    [Date]        DATETIME         NOT NULL,
    [Description] NVARCHAR (MAX)   NOT NULL,
    [IsEmailDelivered] BIT         NOT NULL,
    CONSTRAINT [PK_Lead] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Touchpoint_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id])
);

