USE MailingLists;
GO

/*Процедура добавления, изменения, удаления городов*/
CREATE PROCEDURE up_CityAddEditDetele
@CityId INT, @Name VARCHAR(100), @CountryId INT, @LineAnswer VARCHAR(1000)='' out
AS
BEGIN
 SET @LineAnswer=''
 IF @CityId=0
 BEGIN
  IF NOT EXISTS(SELECT * FROM Country WHERE CountryId=@CountryId) SET @LineAnswer='Указанная страна была удалена другим пользователем!'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT INTO City ([Name], CountryId)
   VALUES (@Name, @CountryId)
   SET @CityId=ISNULL(SCOPE_IDENTITY()*(1-SIGN(@@ERROR)),0)
   IF @CityId!=0
   BEGIN
    COMMIT TRAN
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
   END
  END
 END
 ELSE IF @CityId>0
 BEGIN
  IF NOT EXISTS(SELECT * FROM Country WHERE CountryId=@CountryId) SET @LineAnswer='Указанная страна была удалена другим пользователем!'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE City SET [Name]=@Name, CountryId=@CountryId WHERE CityId=@CityId
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
 ELSE IF @CityId<0
 BEGIN
  DELETE FROM City WHERE CityId=ABS(@CityId)
 END
END
