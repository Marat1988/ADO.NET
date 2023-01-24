CREATE DATABASE MailingLists; --База данных списка рассылок
GO

USE MailingLists;
GO

CREATE TABLE Country --Страны
(
	CountryId INT IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL,
	OKSM VARCHAR(5) NOT NULL --ОКСМ https://classifikators.ru/oksm?ysclid=lda3r5kkxc648643748
	CONSTRAINT PK_Country_CountryId PRIMARY KEY (CountryId),
	CONSTRAINT CK_Country_Name CHECK ([Name]<>''),
	CONSTRAINT UQ_Country_Name UNIQUE ([Name]),
	CONSTRAINT CK_Country_OKSM CHECK (OKSM<>'')
);
GO

CREATE TABLE City --Города
(
	CityId INT IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL,
	CountryId INT NOT NULL
	CONSTRAINT PK_City_CityId PRIMARY KEY (CityId),
	CONSTRAINT UQ_City_Name UNIQUE ([Name]),
	CONSTRAINT CK_City_Name CHECK ([Name]<>'')
);
GO

CREATE TABLE Buyers --Покупатели
(
	BuyersId INT IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL,
	DateBirthday DATETIME NOT NULL,
	CityId INT NOT NULL
	CONSTRAINT PK_Buyers_BuyersId PRIMARY KEY (BuyersId),
	CONSTRAINT UQ_Buyers_Name UNIQUE ([Name]),
	CONSTRAINT CK_Buyers_Name CHECK ([Name]<>'')
);
GO

CREATE UNIQUE NONCLUSTERED INDEX IX_Buyers_NameCityId
ON Buyers (CityId, [Name]);
GO

CREATE TABLE GroupProduct --Разделы (группы товаров)
(
	GroupProductId INT IDENTITY (1,1),
	[Name] VARCHAR(100) NOT NULL
	CONSTRAINT PK_GroupProduct_GroupProductId PRIMARY KEY (GroupProductId),
	CONSTRAINT UQ_GroupProduct_Name UNIQUE ([Name]),
	CONSTRAINT CK_GroupProduct_Name CHECK ([Name]<>'')
);
GO

CREATE TABLE Product --Товары
(
	ProductId INT IDENTITY (1,1),
	[Name] VARCHAR(100) NOT NULL,
	GroupProductId INT NOT NULL,
	CONSTRAINT PK_Product_ProductId PRIMARY KEY (ProductId),
	CONSTRAINT UQ_Product_Name UNIQUE ([Name]),
	CONSTRAINT CK_Product_Name CHECK ([Name]<>'')
);
GO

CREATE TABLE Stock --Акции
(
	StockId INT IDENTITY (1,1),
	[Name] VARCHAR(100) NOT NULL,
	DateBegin DATETIME,
	DateEnd DATETIME,
	CountryId INT NOT NULL,
	GroupProductId INT NOT NULL
	CONSTRAINT PK_Stock_StockId PRIMARY KEY (StockId),
	CONSTRAINT UQ_Stock_Name UNIQUE ([Name]),
	CONSTRAINT CK_Stock_Name CHECK ([Name]<>''),
	CONSTRAINT CK_Stock_Date CHECK (DateBegin<DateEnd)
);
GO

CREATE TABLE LineStock --Строки акций
(
	LineStockId INT IDENTITY (1,1),
	ProductId INT NOT NULL,
	StockId INT NOT NULL,
	Price MONEY NOT NULL
	CONSTRAINT PK_LineStock_LineStockId PRIMARY KEY (LineStockId),
	CONSTRAINT CK_LineStock_Price CHECK (Price>0),
	CONSTRAINT UQ_LineStock_StockIdProductId UNIQUE (StockId,ProductId)
);
GO

CREATE TABLE Mailing --Заинтересованности клиенитов
(
	BuyersId INT NOT NULL,
	StockId INT NOT NULL
	CONSTRAINT PK_Mailing_LineStockId PRIMARY KEY (BuyersId,StockId)
);
GO

/*Связи между таблицами*/
ALTER TABLE City
ADD CONSTRAINT FK_CityCountry_CountryId FOREIGN KEY (CountryId) REFERENCES Country (CountryId) ON DELETE CASCADE;
GO

ALTER TABLE Buyers
ADD CONSTRAINT FK_BuyersCity_CityId FOREIGN KEY (CityId) REFERENCES City (CityId) ON DELETE CASCADE;
GO

ALTER TABLE Product
ADD CONSTRAINT FK_GroupProductProduct_GroupProductId FOREIGN KEY (GroupProductId) REFERENCES GroupProduct (GroupProductId) ON DELETE CASCADE;
GO

ALTER TABLE Stock
ADD CONSTRAINT FK_StockCountry_CountryId FOREIGN KEY (CountryId) REFERENCES Country (CountryId) ON DELETE CASCADE,
	CONSTRAINT FK_StockGroupProduct_GroupProductId FOREIGN KEY (GroupProductId) REFERENCES GroupProduct (GroupProductId) ON DELETE CASCADE;
GO

ALTER TABLE LineStock
ADD CONSTRAINT FK_LineStockProduct_ProductId FOREIGN KEY (ProductId) REFERENCES Product (ProductId),
	CONSTRAINT FK_LineStockStock_StockId FOREIGN KEY (StockId) REFERENCES Stock (StockId) ON DELETE CASCADE;
GO

ALTER TABLE Mailing
ADD CONSTRAINT FK_MailingStock_StockId FOREIGN KEY (StockId) REFERENCES Stock (StockId) ON DELETE CASCADE,
	CONSTRAINT FK_MailingBuyers_BuyersId FOREIGN KEY (BuyersId) REFERENCES Buyers (BuyersId);
GO

/*Защитные триггеры*/
CREATE TRIGGER tg_LineStock_InsertUpdate
ON LineStock
FOR INSERT, UPDATE
AS
BEGIN
 IF EXISTS(SELECT p.ProductId, gp.GroupProductId, s.GroupProductId
		   FROM Product p
		   INNER JOIN inserted i ON p.ProductId=i.ProductId
		   INNER JOIN GroupProduct gp ON p.GroupProductId=gp.GroupProductId
		   INNER JOIN Stock s ON i.StockId=s.StockId
		   WHERE gp.GroupProductId!=s.GroupProductId)
 BEGIN
  RAISERROR('Акции разделены по группам (разделам) товаров. Запрещено добавление товаров не принимающих участие в акции.',16,1)
  ROLLBACK TRAN
 END
END;
GO

CREATE TRIGGER tg_Mailing_InsertUpdate
ON Mailing
FOR INSERT, UPDATE
AS
BEGIN
 IF EXISTS(SELECT b.BuyersId, c.CountryId, s.CountryId
		   FROM Country c
		   INNER JOIN City c1 ON c.CountryId=c1.CountryId
		   INNER JOIN Buyers b ON c1.CityId=b.CityId
		   INNER JOIN inserted i ON b.BuyersId=i.BuyersId
		   INNER JOIN Stock s ON i.StockId=s.StockId
		   WHERE c.CountryId!=s.CountryId)
 BEGIN
  RAISERROR('Запрещено добавление акций из другой страны для данного покупателя',16,1)
  ROLLBACK TRAN
 END
END;
GO

/*Добвление тествых данных*/
INSERT INTO Country ([Name], OKSM)
VALUES ('Российская федерация', '643'),
	   ('Польша', '616');
GO

INSERT INTO City ([Name], CountryId)
VALUES ('Калининград', 1),
	   ('Москва', 1),
	   ('Варшава', 2),
	   ('Краков', 2);
GO


INSERT INTO Buyers (Name, DateBirthday, CityId)
VALUES ('Тухтаров М.Р.', '19880307', 1),
	   ('Иванов И.И.', '19900126', 2),
	   ('Петров П.П.', '19910126', 3),
	   ('Сидоров С.С.', '19920126', 4);
GO

INSERT INTO GroupProduct (Name)
VALUES ('Компьютеры и техника'),
	   ('Продукты');
GO

INSERT INTO Product (Name, GroupProductId)
VALUES ('Оперативная память', 1),
	   ('Клавиатура', 1),
	   ('Сок', 2),
	   ('Сало', 2);
GO

INSERT INTO Stock (Name, DateBegin, DateEnd, CountryId, GroupProductId)
VALUES ('Компьютерная акция', GETDATE(), GETDATE()+10, 1, 1),
	   ('Продуктовая акция', GETDATE()+10, GETDATE()+20, 2, 2);
GO

INSERT INTO LineStock (ProductId, StockId, Price)
VALUES (1, 1, 45),
	   (2, 1, 67),
	   (3, 2, 69),
	   (4, 2, 123);
GO

INSERT INTO Mailing (BuyersId, StockId)
VALUES (1, 1),
	   (2, 1),
	   (3, 2),
	   (4, 2);
GO