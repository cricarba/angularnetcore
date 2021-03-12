 
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100)  NULL,
	[IdentificationDocument] [int] NOT NULL,
	[NumberPhone] [nvarchar](100) NULL
)

 
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](100) NOT NULL,
	[Cost] [int] NOT NULL,
)


CREATE TABLE [dbo].[Bill](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ClientId] [int] NOT NULL,
	[Serial]  [nvarchar](100)  NULL,
	[TotalAmmount] [int] NULL
)

ALTER TABLE Bill
   ADD CONSTRAINT FK_Bill_Client FOREIGN KEY (ClientId)
      REFERENCES Client (Id)


CREATE TABLE [dbo].[BillDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[BillId] [int] NOT NULL,
	[ProductId] [int]  NULL,
	[Ammount] [int] NULL
)

ALTER TABLE BillDetail
   ADD CONSTRAINT FK_BillDetail_Bill FOREIGN KEY (BillId)
      REFERENCES Bill (Id)

 ALTER TABLE BillDetail
   ADD CONSTRAINT FK_BillDetail_Product FOREIGN KEY (ProductId)
      REFERENCES Product (Id)


