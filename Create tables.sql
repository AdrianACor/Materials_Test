USE Materials
GO

CREATE TABLE Buildings(
	[PKBuilding] [int] IDENTITY(1,1) NOT NULL,
	[Building] [nvarchar](50) NULL,
	[Available] [bit] NULL,
 CONSTRAINT [PK_Buildings] PRIMARY KEY CLUSTERED 
(
	[PKBuilding] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE Customers(
	[PKCustomers] [int] IDENTITY(1,1) NOT NULL,
	[Customer] [nvarchar](50) NULL,
	[Prefix] [nvarchar](5) NULL,
	[FKBuilding] [int] NULL,
	[Available] [bit] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[PKCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE Customers WITH CHECK ADD  CONSTRAINT [FK_Customers_Buildings] FOREIGN KEY([FKBuilding])
REFERENCES Buildings ([PKBuilding])
GO

ALTER TABLE Customers CHECK CONSTRAINT [FK_Customers_Buildings]
GO
  
CREATE TABLE PartNumbers(
	[PKPartNumber] [int] IDENTITY(1,1) NOT NULL,
	[PartNumber] [nvarchar](50) NULL,
	[FKCustomer] [int] NULL,
	[Available] [bit] NULL,
 CONSTRAINT [PK_PartNumbers] PRIMARY KEY CLUSTERED 
(
	[PKPartNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE PartNumbers  WITH CHECK ADD  CONSTRAINT [FK_PartNumbers_Customers] FOREIGN KEY([FKCustomer])
REFERENCES Customers ([PKCustomer])
GO

ALTER TABLE PartNumbers CHECK CONSTRAINT [FK_PartNumbers_Customers]
GO







