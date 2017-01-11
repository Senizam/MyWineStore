CREATE TABLE [dbo].[Customer] (
    [Id]          INT IDENTITY(1,1)          NOT NULL,
    [FirstName]   NVARCHAR (50) NOT NULL,
    [LastName]    NVARCHAR (50) NOT NULL,
    [DateOfBirth] DATETIME           NULL,
    [Address]     NVARCHAR (50) NULL,
    [City]        NVARCHAR (50) NULL,
    [EmailAddress] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

