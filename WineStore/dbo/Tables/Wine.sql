CREATE TABLE [dbo].[Wine] (
    [Id]       INT IDENTITY(1,1)           NOT NULL,
    [Name]     NVARCHAR (50) NULL,
    [Type]     NVARCHAR (50) NULL,
    [MadeIn]   NVARCHAR (50) NULL,
    [MadeYear] DATETIME NULL,
    [Price] MONEY NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

