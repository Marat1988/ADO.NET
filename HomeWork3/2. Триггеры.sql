USE DBSTATIONERY;
GO

CREATE TRIGGER TG_TypeStationery_Delete
ON TypeStationery
AFTER DELETE
AS
BEGIN
INSERT ArchiveTypeStationery (Id, [Name], DateDelete)
SELECT Id, [Name], GETDATE() AS DateDelete FROM deleted
END;
GO

CREATE TRIGGER TG_Stationery_Delete
ON Stationery
AFTER DELETE
AS
BEGIN
INSERT ArchiveStationery (Id, [Name], CostPrice, TypeStationeryId, DateDelete)
SELECT Id, [Name], CostPrice, TypeStationeryId, GETDATE() AS DateDelete FROM deleted
END;
GO

CREATE TRIGGER TG_Sales_Delete
ON Sales
AFTER DELETE
AS
BEGIN
INSERT ArchiveSales (Id, DateSale, BuyersId, ManagerId, DateDelete)
SELECT Id, DateSale, BuyersId, ManagerId, GETDATE() AS DateDelete FROM deleted
END;
GO

CREATE TRIGGER TG_Manager_Delete
ON Manager
AFTER DELETE
AS
BEGIN
INSERT ArchiveManager (Id, [Name], DateDelete)
SELECT Id, [Name], GETDATE() AS DateDelete FROM deleted
END;
GO

CREATE TRIGGER TG_LineSales_Delete
ON LineSales
AFTER DELETE
AS
BEGIN
INSERT ArchiveLineSales (Id, SalesId, StationeryId, CostPrice, Price, [Count], Amount, DateDelete)
SELECT Id, SalesId, StationeryId, CostPrice, Price, [Count], Amount, GETDATE() AS DateDelete FROM deleted
END;
GO

CREATE TRIGGER TG_Buyers_Delete
ON Buyers
AFTER DELETE
AS
BEGIN
INSERT ArchiveBuyers (Id, [Name], DateDelete)
SELECT Id, [Name], GETDATE() AS DateDelete FROM deleted
END;
GO