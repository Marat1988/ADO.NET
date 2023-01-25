USE MailingLists;
GO

CREATE PROCEDURE up_CountryAddEditDetele
@CountryId INT, @Name VARCHAR(100), @OKSM VARCHAR(5), @LineAnswer VARCHAR(1000)='' out
AS
BEGIN
 SET @LineAnswer=''
 IF @CountryId=0
 BEGIN
  IF EXISTS(SELECT * FROM Country WHERE [Name]=@Name) SET @LineAnswer='Указаное наименование страны не является уникальным!'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT INTO Country ([Name], [OKSM])
   VALUES (@Name, @OKSM)
   SET @CountryId=ISNULL(SCOPE_IDENTITY()*(1-SIGN(@@ERROR)),0)
   IF @CountryId!=0
   BEGIN
    COMMIT TRAN
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
   END
  END
 END
 ELSE IF @CountryId>0
 BEGIN
  IF EXISTS(SELECT * FROM Country WHERE [Name]=@Name AND CountryId!=@CountryId) SET @LineAnswer='Указаное наименование страны не является уникальным!'
  IF @LineAnswer=''
  BEGIN
   BEGIN TRAN
   UPDATE Country SET [Name]=@Name, OKSM=@OKSM WHERE CountryId=@CountryId
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
 ELSE IF @CountryId<0
 BEGIN
  DELETE FROM Country WHERE CountryId=ABS(@CountryId)
 END
END