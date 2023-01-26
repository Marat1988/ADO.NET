USE MailingLists;
GO

/*Процедура добавления, изменения, удаления разделов (групп товаров)*/
CREATE PROCEDURE up_GroupProductAddEditDelete
@GroupProductId INT, @Name VARCHAR(100), @LineAnswer VARCHAR(1000)='' OUT
AS
BEGIN
 SET @LineAnswer=''
 IF @GroupProductId=0
 BEGIN
  IF EXISTS(SELECT * FROM GroupProduct WHERE [Name]=@Name) SET @LineAnswer='Указанное наименование раздела не является уникальным!'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT INTO GroupProduct([Name])
   VALUES (@Name)
   SET @GroupProductId=ISNULL(SCOPE_IDENTITY()*(1-SIGN(@@ERROR)),0)
   IF @GroupProductId!=0
   BEGIN
    COMMIT TRAN
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
   END
  END
 END
 ELSE IF @GroupProductId>0
 BEGIN
  IF EXISTS(SELECT * FROM GroupProduct WHERE [Name]=@Name AND GroupProductId!=@GroupProductId) SET @LineAnswer='Указанное наименование раздела не является уникальным!'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE GroupProduct SET [Name]=@Name WHERE GroupProductId=@GroupProductId
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
 ELSE IF @GroupProductId<0
 BEGIN
  DELETE FROM GroupProduct WHERE GroupProductId=ABS(@GroupProductId)
 END
END