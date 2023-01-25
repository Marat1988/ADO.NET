USE MailingLists;
GO

/*Процедура добавления, изменения, удаления покупателей*/
CREATE PROCEDURE up_BuyersAddEditDetele
@BuyersId INT, @Name VARCHAR(100), @DateBirthday DATETIME, @CityId INT, @LineAnswer VARCHAR(1000)='' out
AS
BEGIN
 SET @LineAnswer=''
 IF @BuyersId=0
 BEGIN
  IF NOT EXISTS(SELECT * FROM City WHERE CityId=@CityId) SET @LineAnswer='Указанный город был удален другим пользователем!'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT INTO Buyers([Name], DateBirthday, CityId)
   VALUES (@Name, @DateBirthday, @CityId)
   SET @BuyersId=ISNULL(SCOPE_IDENTITY()*(1-SIGN(@@ERROR)),0)
   IF @BuyersId!=0
   BEGIN
    COMMIT TRAN
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
   END
  END
 END
 ELSE IF @BuyersId>0
 BEGIN
  IF NOT EXISTS(SELECT * FROM City WHERE CityId=@CityId) SET @LineAnswer='Указанный город был удален другим пользователем!'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE Buyers SET [Name]=@Name, DateBirthday=@DateBirthday, CityId=@CityId WHERE BuyersId=@BuyersId
   IF @@ERROR=0
   BEGIN
    COMMIT TRAN 
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
   END
  END
 END
 ELSE IF @BuyersId<0
 BEGIN
  DELETE FROM Buyers WHERE BuyersId=ABS(@BuyersId)
 END
END
