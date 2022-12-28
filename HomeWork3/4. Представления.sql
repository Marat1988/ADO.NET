USE DBSTATIONERY;
GO

CREATE VIEW SalesALL
AS
SELECT tst.[Name] AS [Type stationery name], s.[Name] AS [Stationery name], ls.CostPrice AS [Cost price line sales],
	ls.Price AS [Price line sales], ls.[Count] AS [Count line sales], ls.Amount AS [amount line sales],
	sal.DateSale AS [Date sales], m.[Name] AS [Manager name], b.[Name] AS [Buyers name] 
FROM LineSales ls
INNER JOIN Stationery s ON ls.StationeryId=s.Id
INNER JOIN TypeStationery tst ON s.TypeStationeryId=tst.Id
INNER JOIN Sales sal ON ls.SalesId=sal.Id
INNER JOIN Manager m ON sal.ManagerId=m.Id
INNER JOIN Buyers b ON sal.BuyersId=b.Id;
GO