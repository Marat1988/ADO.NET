CREATE DATABASE Warehouse
COLLATE Cyrillic_General_CI_AS;
GO
USE Warehouse;
GO
/*Создаю таблицы*/
CREATE TABLE Product --Продукты
(
	Id INT IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL,
	TypeProductId INT NOT NULL,
	Color VARCHAR(20) NOT NULL,
	Caloric INT NOT NULL
	CONSTRAINT PK_Product_Id PRIMARY KEY(Id),
	CONSTRAINT UQ_Product_Name UNIQUE([Name]),
	CONSTRAINT CK_Product_Caloric CHECK (Caloric>0)
);
GO
CREATE TABLE TypeProducts --Типы продуктов
(
	TypeProductId INT IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL
	CONSTRAINT PK_TypeProducts_TypeProductId PRIMARY KEY(TypeProductId),
	CONSTRAINT UQ_TypeProducts_Name UNIQUE([Name])
);
GO
/*Связываю таблицы*/
ALTER TABLE Product
ADD CONSTRAINT FK_TypeProducts_TypeProductId FOREIGN KEY(TypeProductId) REFERENCES TypeProducts(TypeProductId);
GO
/*Заполнение тестовыми данными*/
INSERT INTO TypeProducts([Name])
VALUES ('Овощ'),
	   ('Фрукт');
GO

INSERT INTO Product ([Name], TypeProductId, Color, Caloric)
VALUES ('Баклажан', 1, 'Зеленый', 28),
	   ('Лук репчатый', 1, 'Зеленый', 43),
	   ('Морковь', 1, 'Оранжевый', 43),
	   ('Бананы', 2, 'Желтый', 90),
	   ('Смородина', 2, 'Черный', 43),
	   ('Вишня', 2, 'Красная', 25);
GO

/*Запрос*/
CREATE VIEW vw_ShowInfoProduct
AS
SELECT p.Name AS [Name product], tp.Name AS [Type name product], p.Color, p.Caloric
FROM TypeProducts tp
INNER JOIN Product p ON tp.TypeProductId=p.TypeProductId;
GO

/*Хранимая процедура*/
CREATE PROCEDURE [dbo].[up_sel_ShowInfoProductColorCount]
@Color VARCHAR(20), @CountProduct INT=0 OUT
AS
BEGIN
SELECT @CountProduct=COUNT(*)
FROM vw_ShowInfoProduct
WHERE Color=@Color
END;

GO


