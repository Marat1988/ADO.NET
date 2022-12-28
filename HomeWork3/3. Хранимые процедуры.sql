USE DBSTATIONERY;
GO

/*Процедура добавления, удаления, изменения нового типа канцтоваров*/
CREATE PROCEDURE [dbo].[up_upd_InsertUpdateDeleteTypeProduct]
@TypeStationeryId INT, @Name VARCHAR(100), @LineAnswer VARCHAR(1000)=''  OUT
AS
BEGIN
 SET NOCOUNT ON
 SET @LineAnswer=''
 IF @TypeStationeryId=0 --Добавление нового типа товара
 BEGIN
  IF EXISTS(SELECT * FROM TypeStationery WHERE [Name]=@Name) SET @LineAnswer='Указанное название типа канцтоваров не является уникальным'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT TypeStationery([Name])
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
 ELSE IF @TypeStationeryId>0 --Изменение типа продукта
 BEGIN
  IF EXISTS(SELECT * FROM TypeStationery WHERE [Name]=@Name) SET @LineAnswer='Указанное название типа канцтоваров не является уникальным'
  IF NOT EXISTS(SELECT * FROM TypeStationery WHERE Id=@TypeStationeryId) SET @LineAnswer='Указанный тип канцтоваров не существует или был удален'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE TypeStationery SET [Name]=@Name
   WHERE Id=@TypeStationeryId
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
 ELSE IF @TypeStationeryId<0
 BEGIN
  IF EXISTS(SELECT * FROM Stationery WHERE TypeStationeryId=ABS(@TypeStationeryId)) SET @LineAnswer='Удаление данного типа канцтовара не возможно, т.к. на этом типе привязаны канцтовары'
  IF NOT EXISTS(SELECT * FROM TypeStationery WHERE Id=ABS(@TypeStationeryId)) SET @LineAnswer='Указанный тип канцтовара не существует или был удален'
  IF @LineAnswer=''
  BEGIN
   DELETE FROM TypeStationery WHERE Id=ABS(@TypeStationeryId)
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

/*Процедура добавления, удаления, изменения новых менеджеров*/
CREATE PROCEDURE [dbo].[up_upd_InsertUpdateDeleteManager]
@ManagerId INT, @Name VARCHAR(100), @LineAnswer VARCHAR(1000)=''  OUT
AS
BEGIN
 SET NOCOUNT ON
 SET @LineAnswer=''
 IF @ManagerId=0 --Добавление нового менеджера
 BEGIN
  IF EXISTS(SELECT * FROM Manager WHERE [Name]=@Name) SET @LineAnswer='Указанное имя менеджера не является уникальным'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT Manager([Name])
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
 ELSE IF @ManagerId>0 --Изменение менеждера
 BEGIN
  IF EXISTS(SELECT * FROM Manager WHERE [Name]=@Name) SET @LineAnswer='Указанное имя менеджера не является уникальным'
  IF NOT EXISTS(SELECT * FROM Manager WHERE Id=@ManagerId) SET @LineAnswer='Указанный менеджер не существует или был удален'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE Manager SET [Name]=@Name
   WHERE Id=@ManagerId
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
 ELSE IF @ManagerId<0
 BEGIN
  IF EXISTS(SELECT * FROM Sales WHERE ManagerId=ABS(@ManagerId)) SET @LineAnswer='Удаление менеджера не возможно, т.к. на нем привязаны продажи'
  IF NOT EXISTS(SELECT * FROM Manager WHERE Id=ABS(@ManagerId)) SET @LineAnswer='Указанный менеджер не существует или был удален'
  IF @LineAnswer=''
  BEGIN
   DELETE FROM Manager WHERE Id=ABS(@ManagerId)
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

/*Процедура добавления, удаления, изменения новых фирм покупателей*/
CREATE PROCEDURE [dbo].[up_upd_InsertUpdateDeleteBuyers]
@BuyersId INT, @Name VARCHAR(100), @LineAnswer VARCHAR(1000)=''  OUT
AS
BEGIN
 SET NOCOUNT ON
 SET @LineAnswer=''
 IF @BuyersId=0 --Добавление нового покупателя
 BEGIN
  IF EXISTS(SELECT * FROM Buyers WHERE [Name]=@Name) SET @LineAnswer='Указанное имя покупателя не является уникальным'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT Buyers([Name])
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
 ELSE IF @BuyersId>0 --Изменение покупателя
 BEGIN
  IF EXISTS(SELECT * FROM Buyers WHERE [Name]=@Name) SET @LineAnswer='Указанное имя покупателя не является уникальным'
  IF NOT EXISTS(SELECT * FROM Buyers WHERE Id=@BuyersId) SET @LineAnswer='Указанный покупатель не существует или был удален'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE Buyers SET [Name]=@Name
   WHERE Id=@BuyersId
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
 ELSE IF @BuyersId<0
 BEGIN
  IF EXISTS(SELECT * FROM Sales WHERE BuyersId=ABS(@BuyersId)) SET @LineAnswer='Удаление покупателя не возможно, т.к. на нем привязаны продажи'
  IF NOT EXISTS(SELECT * FROM Sales WHERE Id=ABS(@BuyersId)) SET @LineAnswer='Указанный покупатель не существует или был удален'
  IF @LineAnswer=''
  BEGIN
   DELETE FROM Buyers WHERE Id=ABS(@BuyersId)
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

/*Процедура добавления, удаления, изменения канцтоваров*/
CREATE PROCEDURE [dbo].[up_upd_InsertUpdateDeleteStationery]
@StationeryId INT, @Name VARCHAR(100), @CostPrice MONEY, @TypeStationeryId INT,  @LineAnswer VARCHAR(1000)='' OUT
AS
BEGIN
 SET NOCOUNT ON
 SET @LineAnswer=''
 IF @StationeryId=0 --Добавление нового канцтовара
 BEGIN
  IF NOT EXISTS(SELECT * FROM TypeStationery WHERE Id=@TypeStationeryId) SET @LineAnswer='Указанный тип канцтовара не существует'
  IF EXISTS(SELECT * FROM Stationery WHERE [Name]=@Name) SET @LineAnswer='Указанное имя канцтовара не является уникальным'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT INTO Stationery([Name], CostPrice, TypeStationeryId)
   VALUES (@Name, @CostPrice, @TypeStationeryId)
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
 ELSE IF @StationeryId>0 --Изменение канцтовара
 BEGIN
  IF NOT EXISTS(SELECT * FROM TypeStationery WHERE Id=@TypeStationeryId) SET @LineAnswer='Указанный тип канцтовара не существует'
  IF EXISTS(SELECT * FROM Stationery WHERE [Name]=@Name) SET @LineAnswer='Указанное имя канцтовара не является уникальным'
  IF NOT EXISTS(SELECT * FROM Stationery WHERE Id=@StationeryId) SET @LineAnswer='Указанный канцтовар не существует или был удален'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE Stationery SET [Name]=@Name, CostPrice=@CostPrice, TypeStationeryId=@TypeStationeryId
   WHERE Id=@StationeryId
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
 ELSE IF @StationeryId<0 --Удаление канцтовара
 BEGIN
  IF NOT EXISTS(SELECT * FROM Stationery WHERE Id=ABS(@StationeryId)) SET @LineAnswer='Указанный канцтовар не существует или был удален'
  IF EXISTS(SELECT * FROM Stationery s INNER JOIN LineSales ls ON s.Id=ls.StationeryId WHERE s.Id=@StationeryId) SET @LineAnswer='Удаление канцтоваратовара не возможно, т.к. на нем завязаны продажи'
  IF @LineAnswer=''
  BEGIN
   DELETE Stationery WHERE Id=ABS(@StationeryId)
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