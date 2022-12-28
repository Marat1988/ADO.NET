USE DBSTATIONERY;
GO

CREATE VIEW [dbo].[vw_SalesALL]
AS
SELECT tst.[Name] AS [Type stationery name], s.[Name] AS [Stationery name], ls.CostPrice AS [Cost price line sales],
	ls.Price AS [Price line sales], ls.[Count] AS [Count stationery], ls.Amount AS [Amount line sales],
	sal.DateSale AS [Date sales], m.[Name] AS [Manager name], b.[Name] AS [Buyers name] 
FROM LineSales ls
INNER JOIN Stationery s ON ls.StationeryId=s.Id
INNER JOIN TypeStationery tst ON s.TypeStationeryId=tst.Id
INNER JOIN Sales sal ON ls.SalesId=sal.Id
INNER JOIN Manager m ON sal.ManagerId=m.Id
INNER JOIN Buyers b ON sal.BuyersId=b.Id;
GO

CREATE VIEW vw_InfoStationery
AS
SELECT s.Id AS [Id stationery], s.[Name] AS [Name stationery], s.CostPrice AS [Cost price stationery],
	tp.Id AS [Id type stationery], tp.[Name] AS [Name type stationery]
FROM TypeStationery tp
INNER JOIN Stationery s ON tp.Id=s.TypeStationeryId
GO