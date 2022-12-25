CREATE DATABASE Warehouse
COLLATE Cyrillic_General_CI_AS;
GO
USE Warehouse;
GO

/*Создание таблиц*/
CREATE TABLE TypeProduct --Типы товара
(
	Id INT IDENTITY(1,1),
	[Name] VARCHAR(100)
	CONSTRAINT PK_TypeProduct_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_TypeProduc_Name UNIQUE ([Name])
);
GO

CREATE TABLE Suppliers --Поставщик товара
(
	Id INT IDENTITY(1,1),
	[Name] VARCHAR(100)
	CONSTRAINT PK_Suppliers_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_Suppliers_Name UNIQUE ([Name])
);
GO

CREATE TABLE Products --Товары
(
	Id INT IDENTITY(1,1),
	[Name] VARCHAR(100),
	Balance INT NOT NULL, --Остаток
	CostPrice MONEY NOT NULL, --Себестоимость
	LastDateDelivery DATE, --Последняя дата поставки
	TypeProductId INT NOT NULL,
	SupplierId INT NOT NULL
	CONSTRAINT PK_Products_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_Products_Name UNIQUE([Name]),
	CONSTRAINT CK_Products_CostPrice CHECK (CostPrice>0),
	CONSTRAINT CK_Products_Balance CHECK (Balance>=0)
);
GO

/*Создание связей между таблицами*/
ALTER TABLE Products
ADD CONSTRAINT FK_Products_TypeProductId FOREIGN KEY(TypeProductId) REFERENCES TypeProduct(Id),
	CONSTRAINT FK_Products_SupplierId FOREIGN KEY(SupplierId) REFERENCES Suppliers(Id);
GO

/*Заполнение таблиц тектовыми данными*/
INSERT TypeProduct([Name])
VALUES ('МЫЛА'),
	   ('СОКИ');
GO

INSERT INTO Suppliers([Name])
VALUES ('ООО Рога и копыта'),
	   ('ООО Быки и коровы');
GO

INSERT INTO Products([Name], Balance, CostPrice, LastDateDelivery, TypeProductId, SupplierId)
VALUES ('Мыло хозайственное', 100, 5.65, '20220501', 1, 1),
	   ('Мыло банное', 200, 7.65, '20220701', 1, 1),
	   ('Сок "Добрый"', 30, 11.25, GETDATE(), 2, 2),
	   ('Сок "Нежный"', 10, 20.2, '20221122', 2, 2);
GO

/*Процедура добавления, удаления, изменения товаров*/
CREATE PROCEDURE [dbo].[up_upd_InsertUpdateDeleteProduct]
@ProductId INT, @Name VARCHAR(100), @Balance INT, @CostPrice MONEY, @LastDateDelivery DATE, @TypeProductId INT, @SupplierId INT, @LineAnswer VARCHAR(1000)='' OUT
AS
BEGIN
 SET NOCOUNT ON
 SET @LineAnswer=''
 IF @ProductId=0 --Добавление нового товара
 BEGIN
  IF NOT EXISTS(SELECT * FROM TypeProduct WHERE Id=@TypeProductId) SET @LineAnswer='Указанный тип товара не существует'
  IF NOT EXISTS(SELECT * FROM Suppliers WHERE Id=@SupplierId) SET @LineAnswer='Указанный поставщик не существует'
  IF EXISTS(SELECT * FROM Products WHERE [Name]=@Name) SET @LineAnswer='Указанное имя не является уникальным'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT INTO Products([Name], Balance, CostPrice, LastDateDelivery, TypeProductId, SupplierId)
   VALUES (@Name, @Balance, @CostPrice, @LastDateDelivery, @TypeProductId, @SupplierId)
   IF @@ERROR=0
   BEGIN
    COMMIT TRAN
    RETURN 0
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
	RETURN -1
   END
  END
  ELSE RETURN -1
 END
 ELSE IF @ProductId>0 --Изменение нового товара
 BEGIN
  IF NOT EXISTS(SELECT * FROM TypeProduct WHERE Id=@TypeProductId) SET @LineAnswer='Указанный тип товара не существует'
  IF NOT EXISTS(SELECT * FROM Suppliers WHERE Id=@SupplierId) SET @LineAnswer='Указанный поставщик не существует'
  IF EXISTS(SELECT * FROM Products WHERE [Name]=@Name) SET @LineAnswer='Указанное имя не является уникальным'
  IF NOT EXISTS(SELECT * FROM Products WHERE Id=@ProductId) SET @LineAnswer='Указанный товар не существует или был удален'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE Products SET [Name]=@Name, Balance=@Balance, CostPrice=@CostPrice, LastDateDelivery=@LastDateDelivery, TypeProductId=@TypeProductId, SupplierId=@SupplierId
   WHERE Id=@ProductId
   IF @@ERROR=0
   BEGIN
    COMMIT TRAN
	RETURN 0
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
	RETURN -1
   END
  END
  ELSE RETURN -1
 END
 ELSE IF @ProductId<0 --Удаление товара
 BEGIN
  IF NOT EXISTS(SELECT * FROM Products WHERE Id=ABS(@ProductId)) SET @LineAnswer='Указанный товар не существует или был удален'
  IF @LineAnswer=''
  BEGIN
   DELETE Products WHERE Id=ABS(@ProductId)
   IF @@ERROR=0
    RETURN 0
   ELSE
    RETURN -1
  END
  ELSE RETURN -1
 END
 SET NOCOUNT OFF
END;
GO

/*Процедура добавления, удаления, изменения типа товара*/
CREATE PROCEDURE [dbo].[up_upd_InsertUpdateDeleteTypeProduct]
@TypeProductId INT, @Name VARCHAR(100), @LineAnswer VARCHAR(1000)=''  OUT
AS
BEGIN
 SET NOCOUNT ON
 SET @LineAnswer=''
 IF @TypeProductId=0 --Добавление нового типа товара
 BEGIN
  IF EXISTS(SELECT * FROM TypeProduct WHERE [Name]=@Name) SET @LineAnswer='Указанное название типа товара не является уникальным'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT TypeProduct([Name])
   VALUES (@Name)
   IF @@ERROR=0
   BEGIN
    COMMIT TRAN
	RETURN 0
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
	RETURN -1
   END
  END
  ELSE RETURN -1
 END
 ELSE IF @TypeProductId>0 --Изменение типа продукта
 BEGIN
  IF EXISTS(SELECT * FROM TypeProduct WHERE [Name]=@Name) SET @LineAnswer='Указанное название типа товара не является уникальным'
  IF NOT EXISTS(SELECT * FROM TypeProduct WHERE Id=@TypeProductId) SET @LineAnswer='Указанный тип товара не существует или был удален'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE TypeProduct SET [Name]=@Name
   WHERE Id=@TypeProductId
   IF @@ERROR=0
   BEGIN
    COMMIT TRAN
	RETURN 0
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
	RETURN -1
   END
  END
  ELSE RETURN -1
 END
 ELSE IF @TypeProductId<0
 BEGIN
  IF EXISTS(SELECT * FROM Products WHERE TypeProductId=ABS(@TypeProductId)) SET @LineAnswer='Удаление данного типа товара не возможно, т.к. на этом типе привязаны товары'
  IF NOT EXISTS(SELECT * FROM TypeProduct WHERE Id=ABS(@TypeProductId)) SET @LineAnswer='Указанный тип товара не существует или был удален'
  IF @LineAnswer=''
  BEGIN
   DELETE FROM TypeProduct WHERE Id=ABS(@TypeProductId)
   IF @@ERROR=0
    RETURN 0
   ELSE
    RETURN -1
  END
  ELSE RETURN -1
 END
 SET NOCOUNT OFF
END;
GO

/*Процедура добавления, удаления, изменения поставщика*/
CREATE PROCEDURE [dbo].[up_upd_InsertUpdateDeleteSupplier]
@SupplierId INT, @Name VARCHAR(100), @LineAnswer VARCHAR(1000)='' OUT
AS
BEGIN
 SET NOCOUNT ON
 SET @LineAnswer=''
 IF @SupplierId=0 --Добавление нового поставщика
 BEGIN
  IF EXISTS(SELECT * FROM Suppliers WHERE [Name]=@Name) SET @LineAnswer='Указанное название типа товара не является уникальным'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT Suppliers([Name])
   VALUES (@Name)
   IF @@ERROR=0
   BEGIN
    COMMIT TRAN
	RETURN 0
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
	RETURN -1
   END
  END
  ELSE RETURN -1
 END
 ELSE IF @SupplierId>0 --Изменение типа продукта
 BEGIN
  IF EXISTS(SELECT * FROM Suppliers WHERE [Name]=@Name) SET @LineAnswer='Указанное имя поставщика не является уникальным'
  IF NOT EXISTS(SELECT * FROM Suppliers WHERE Id=ABS(@SupplierId)) SET @LineAnswer='Указанный поставщик не существует или был удален'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE Suppliers SET [Name]=@Name
   WHERE Id=@SupplierId
   IF @@ERROR=0
   BEGIN
    COMMIT TRAN
	RETURN 0
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
	RETURN -1
   END
  END
  ELSE RETURN -1
 END
 ELSE IF @SupplierId<0
 BEGIN
  IF EXISTS(SELECT * FROM Products WHERE SupplierId=ABS(@SupplierId)) SET @LineAnswer='Удаление данного поставщика не возможно, т.к. на этом поставщике привязаны товары'
  IF NOT EXISTS(SELECT * FROM Suppliers WHERE Id=ABS(@SupplierId)) SET @LineAnswer='Указанный поставщик не существует или был удален'
  IF @LineAnswer=''
  BEGIN
   DELETE FROM Suppliers WHERE Id=ABS(@SupplierId)
   IF @@ERROR=0
    RETURN 0
   ELSE
    RETURN -1
  END
  ELSE RETURN -1
 END
 SET NOCOUNT OFF
END;
GO

/*Создание запроса*/
CREATE VIEW [dbo].[vw_InfoProducts]
AS
SELECT p.Id AS [Product Id], p.[Name] AS [Name product], p.Balance AS [Balance product], p.CostPrice AS [Cost price], p.LastDateDelivery AS [Last date delivery],
	tp.[Name] AS [Type product name], s.[Name] AS [Supplier name] 
FROM Products p
INNER JOIN TypeProduct tp ON p.TypeProductId=tp.Id
INNER JOIN Suppliers s ON p.SupplierId=s.Id;
GO

