CREATE DATABASE DBSTATIONERY
COLLATE Cyrillic_General_CI_AS;
GO

USE DBSTATIONERY;
GO

/*Создание таблиц*/
CREATE TABLE TypeStationery --Типы канцтоваров
(
	Id INT IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL
	CONSTRAINT PK_TypeStationery_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_TypeStationery_Name UNIQUE([Name])
);
GO

CREATE TABLE Stationery --Канцтовары
(
	Id INT IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL,
	CostPrice MONEY NOT NULL, --Текущая себестоимость
	TypeStationeryId INT NOT NULL
	CONSTRAINT PK_Stationery_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_Stationery_Name UNIQUE([Name]),
	CONSTRAINT CK_Stationery_CostPrice CHECK (CostPrice>0)
);
GO

CREATE TABLE Manager --Менеждеры
(
	Id INT IDENTITY(1,1),
	[Name] VARCHAR(50) NOT NULL
	CONSTRAINT PK_Manager_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_Manager_Name UNIQUE([Name])
);
GO

CREATE TABLE Buyers --Покупатели (фирмы покупателей)
(
	Id INT IDENTITY(1,1),
	[Name] VARCHAR(50) NOT NULL
	CONSTRAINT PK_Buyers_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_Buyers_Name UNIQUE([Name])
);
GO

CREATE TABLE Sales --Продажи
(
	Id INT IDENTITY(1,1),
	[DateSale] DATETIME NOT NULL,
	BuyersId INT NOT NULL,
	ManagerId INT NOT NULL
	CONSTRAINT PK_Sales_Id PRIMARY KEY(Id)
);
GO

CREATE TABLE LineSales --Строки продажи
(
	Id INT IDENTITY(1,1),
	SalesId INT NOT NULL,
	StationeryId INT NOT NULL,
	CostPrice MONEY NOT NULL, --Себестоимость на момент продажи
	Price MONEY NOT NULL, --Цена продажи
	[Count] INT NOT NULL, --Количество
	Amount AS (CONVERT([MONEY], ROUND([Count]*Price,(2)),(0)))
	CONSTRAINT PK_LineSales_Id PRIMARY KEY(Id),
	CONSTRAINT CK_LineSales_CostPrice CHECK (CostPrice>0),
	CONSTRAINT CK_LineSales_Price CHECK (Price>0),
	CONSTRAINT CK_LineSales_Count CHECK ([Count]>0)
);
GO

/*Создание таблиц Архив*/
CREATE TABLE ArchiveTypeStationery --Типы канцтоваров
(
	Id INT NOT NULL,
	[Name] VARCHAR(100) NOT NULL,
	DateDelete DATETIME NOT NULL --Дата удаления
	CONSTRAINT PK_ArchiveTypeStationery_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_ArchiveTypeStationery_Name UNIQUE([Name])
);
GO

CREATE TABLE ArchiveStationery --Канцтовары
(
	Id INT NOT NULL,
	[Name] VARCHAR(100) NOT NULL,
	CostPrice MONEY NOT NULL,
	TypeStationeryId INT NOT NULL,
	DateDelete DATETIME NOT NULL --Дата удаления
	CONSTRAINT PK_ArchiveStationery_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_ArchiveStationery_Name UNIQUE([Name]),
	CONSTRAINT CK_ArchiveStationery_CostPrice CHECK (CostPrice>0)
);
GO

CREATE TABLE ArchiveManager --Менеждеры
(
	Id INT NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	DateDelete DATETIME NOT NULL --Дата удаления
	CONSTRAINT PK_ArchiveManager_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_ArchiveManager_Name UNIQUE([Name])
);
GO

CREATE TABLE ArchiveBuyers --Покупатели (фирмы покупателей)
(
	Id INT NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	DateDelete DATETIME NOT NULL --Дата удаления
	CONSTRAINT PK_ArchiveBuyers_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_ArchiveBuyers_Name UNIQUE([Name])
);
GO

CREATE TABLE ArchiveSales --Продажи
(
	Id INT NOT NULL,
	[DateSale] DATETIME NOT NULL,
	BuyersId INT NOT NULL,
	ManagerId INT NOT NULL,
	DateDelete DATETIME NOT NULL --Дата удаления
	CONSTRAINT PK_ArchiveSales_Id PRIMARY KEY(Id)
);
GO

CREATE TABLE ArchiveLineSales --Строки продажи
(
	Id INT NOT NULL,
	SalesId INT NOT NULL,
	StationeryId INT NOT NULL,
	CostPrice MONEY NOT NULL, --Себестоимость на момент продажи
	Price MONEY NOT NULL, --Цена продажи
	[Count] INT NOT NULL, --Количество
	Amount MONEY NOT NULL,
	DateDelete DATETIME NOT NULL --Дата удаления
	CONSTRAINT PK_ArchiveLineSales_Id PRIMARY KEY(Id),
	CONSTRAINT CK_ArchiveLineSales_CostPrice CHECK (CostPrice>0),
	CONSTRAINT CK_ArchiveLineSales_Price CHECK (Price>0),
	CONSTRAINT CK_ArchiveLineSales_Count CHECK ([Count]>0)
);
GO

/*Создание связей между таблицами*/
ALTER TABLE Stationery
ADD CONSTRAINT FK_Stationery_TypeStationeryId FOREIGN KEY (TypeStationeryId) REFERENCES TypeStationery(Id);
GO

ALTER TABLE Sales
ADD CONSTRAINT FK_Sales_BuyersId FOREIGN KEY(BuyersId) REFERENCES Buyers(Id),
	CONSTRAINT FK_Sales_ManagerId FOREIGN KEY(ManagerId) REFERENCES Manager(Id);
GO

ALTER TABLE LineSales
ADD CONSTRAINT FK_LineSales_SalesId FOREIGN KEY(SalesId) REFERENCES Sales(Id),
	CONSTRAINT FK_LineSales_StationeryId FOREIGN KEY(StationeryId) REFERENCES Stationery(Id);
GO

/*Заполнение таблиц тестовыми данными*/
INSERT TypeStationery ([Name])
VALUES ('Офисные'),
	   ('Школьные');
GO

INSERT INTO Stationery ([Name], CostPrice, TypeStationeryId)
VALUES ('Скрепки', 19.25, 1),
	   ('Корректоры', 20.25, 1),
	   ('Тетрадь в линейку', 10.25, 2);
GO

INSERT INTO Manager([Name])
VALUES ('Зорин И.'),
	   ('Пономаренко М.');
GO

INSERT INTO Buyers([Name])
VALUES ('ООО Тензор'),
	   ('ООО Три брата');
GO

INSERT INTO Sales ([DateSale], BuyersId, ManagerId)
VALUES ('20221201', 1, 1),
	   ('20221227', 2, 2);
GO

INSERT INTO LineSales (SalesId, StationeryId, CostPrice, Price, [Count])
VALUES (1, 1, 19.25, 25, 10),
	   (1, 2, 20.25, 50, 5),
	   (1, 3, 10.25, 100, 200),
	   (2, 1, 19.25, 30, 200);
GO
