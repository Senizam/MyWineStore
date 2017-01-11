CREATE TABLE [dbo].[OrderLineItem]
(
	OrdersID INT NOT NULL,
	WineID INT NOT NULL, 
	[QuantityID] INT NULL, 
    CONSTRAINT [PK_OrderLineItem] PRIMARY KEY ([WineID], [OrdersID]), 
	CONSTRAINT [FK_OrderLineItem_Wine] FOREIGN KEY (WineID) REFERENCES Wine(ID), 
	CONSTRAINT [FK_OrderLineItem_Order] FOREIGN KEY (OrdersID) REFERENCES [Orders](ID)
)
