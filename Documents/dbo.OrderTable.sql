﻿CREATE TABLE Orders
(
	[OrderID] INT NOT NULL PRIMARY KEY IDENTITY,
	[AddressFinish] NVARCHAR(200) NOT NULL,
	[AddressStart] NVARCHAR(200) NOT NULL,
	[Date] NVARCHAR(20) NOT NULL,
	[ExecutorID] INT NOT NULL,
	[FIO] NVARCHAR(100) NOT NULL,
	[Price] DECIMAL(16,2) NOT NULL,
	[Status] NVARCHAR(20) NOT NULL,
	[Time] NVARCHAR(20) NOT NULL
)