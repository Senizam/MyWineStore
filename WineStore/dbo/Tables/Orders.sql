CREATE TABLE [dbo].[Orders] (
    [Id]                       INT IDENTITY(1,1)           NOT NULL,
	[CustomerID]				INT NOT NULL,
    [FirstName]                NVARCHAR (50) NULL,
    [LastName]                 NVARCHAR (50) NULL,
    [EmailAddress]             NVARCHAR (50) NULL,
    [Phonenumber]              NVARCHAR (50) NULL,
    [CreditCardNumber]         NVARCHAR (32) NULL,
    [CreditCardName]           NVARCHAR (50) NULL,
    [CVV]                      NVARCHAR (4)  NULL,
    [CreditCardExpirationDate] DATETIME      NULL,
    [ShippingCity1] NVARCHAR(50) NULL, 
    [ShippingCity2] NCHAR(10) NULL, 
    [ShippingCity] NCHAR(10) NULL, 
    [ShippingState] NCHAR(10) NULL, 
    [ShippingPostalCode] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Orders_Customer] FOREIGN KEY (CustomerID) REFERENCES Customer(ID)
);

