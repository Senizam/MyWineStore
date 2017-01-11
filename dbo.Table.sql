CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [DateOfBirth] INT NOT NULL, 
    [Address] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL
)
