CREATE DATABASE CountryDB;
GO

USE CountryDB;
GO

/*Создание таблиц*/
CREATE TABLE Country
(
	CountryId INT IDENTITY(1,1),
	[Name] VARCHAR(100) NOT NULL,
	Area INT NOT NULL
	CONSTRAINT PK_Country_CountryId PRIMARY KEY (CountryId),
	CONSTRAINT UQ_Country_Name UNIQUE ([Name]),
	CONSTRAINT CK_Country_Name CHECK ([Name]<>''),
	CONSTRAINT CK_Country_Area CHECK (Area>0),
);
GO

CREATE TABLE City
(
	CityId INT IDENTITY(1,1),
	CountryId INT NOT NULL,
	[Name] VARCHAR(100) NOT NULL,
	CountPeople INT NOT NULL
	CONSTRAINT PK_City_CityId PRIMARY KEY (CityId),
	CONSTRAINT CK_City_CountPeople CHECK (CountPeople>0),
	CONSTRAINT CK_City_Name CHECK ([Name]<>''),
);
GO

CREATE TABLE BigCity
(
	CityId INT NOT NULL,
	Mayor VARCHAR(100) NOT NULL,
	CONSTRAINT PK_BigCity_CityId PRIMARY KEY (CityId),
	CONSTRAINT CK_BigCity_CountPeople CHECK (Mayor<>'')
);
GO

CREATE TABLE Capital
(
	CityId INT NOT NULL,
	Mayor VARCHAR(100) NOT NULL,
	Area INT NOT NULL
	CONSTRAINT PK_Capital_CityId PRIMARY KEY (CityId),
	CONSTRAINT CK_Capital_Mayor CHECK (Mayor<>''),
	CONSTRAINT CK_Capital_Area CHECK (Area>0),
);
GO
/*Связи между таблицами*/

ALTER TABLE City
ADD CONSTRAINT FK_City_CountryId FOREIGN KEY (CountryId) REFERENCES Country (CountryId) ON DELETE CASCADE;
GO

ALTER TABLE BigCity
ADD CONSTRAINT FK_BigCity_City FOREIGN KEY (CityId) REFERENCES City (CityId) ON DELETE CASCADE;
GO

ALTER TABLE Capital
ADD CONSTRAINT FK_Capital_City FOREIGN KEY (CityId) REFERENCES City (CityId) ON DELETE CASCADE;
GO
/*Заполнение тестовыми данными*/
INSERT INTO Country
VALUES ('Российская Федерация', 17125191),
	   ('Польша', 312696);
GO

INSERT INTO City (CountryId, [Name], CountPeople)
VALUES (1, 'Москва', 12632409),
	   (1, 'Калининград', 498260),
	   (2, 'Варшава', 1860281),
	   (2, 'Краков', 800653);
GO

INSERT INTO Capital (CityId, Mayor, Area)
VALUES (1, 'Собянин С.С.', 2561),
	   (3, 'Рафал Тшасковский', 517);
GO

INSERT INTO BigCity (CityId, Mayor)
VALUES (1, 'Собянин С.С.');
GO