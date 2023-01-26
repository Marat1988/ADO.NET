USE MailingLists;
GO

/*Процедура добавления, изменения, удаления разделов (групп товаров)*/
CREATE PROCEDURE up_StockProductAddEditDelete
@LineStockId INT, @ProductId INT, @StockId INT, @Price MONEY, @LineAnswer VARCHAR(1000)='' OUT
AS
BEGIN
 SET @LineAnswer=''
 IF @LineStockId=0
 BEGIN
  IF EXISTS(SELECT * FROM LineStock WHERE ProductId=@ProductId AND StockId=@StockId) SET @LineAnswer='Запрещено добавление товара, который уже учавствует в данной акции'
  IF NOT EXISTS(SELECT * 
				FROM Stock
				WHERE GroupProductId=(SELECT gp.GroupProductId 
									  FROM LineStock ls
									  INNER JOIN Product p ON ls.ProductId=p.ProductId
									  INNER JOIN GroupProduct gp ON p.GroupProductId=gp.GroupProductId
									  WHERE ls.StockId=@StockId AND ls.ProductId=@ProductId)) SET @LineAnswer='Акции разделены по группам (разделам) товаров. Запрещено добавление товаров в акцию, не подходящих по данным критериям!'

  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   INSERT INTO LineStock(ProductId, StockId, Price)
   VALUES (@ProductId, @StockId, @Price)
   SET @LineStockId=ISNULL(SCOPE_IDENTITY()*(1-SIGN(@@ERROR)),0)
   IF @LineStockId!=0
   BEGIN
    COMMIT TRAN
   END
   ELSE
   BEGIN
    ROLLBACK TRAN
   END
  END
 END
 ELSE IF @LineStockId>0
 BEGIN
  IF NOT EXISTS(SELECT * FROM LineStock WHERE ProductId=@ProductId AND StockId=@StockId AND LineStockId=@LineStockId) SET @LineAnswer='Запрещено смена товара в акции. Только удаление!'
  IF @LineAnswer=''
  BEGIN
  BEGIN TRAN
   UPDATE LineStock SET Price=@Price WHERE LineStockId=@LineStockId AND ProductId=@ProductId AND StockId=@StockId
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
 ELSE IF @LineStockId<0
 BEGIN
  DELETE FROM GroupProduct WHERE GroupProductId=ABS(@LineStockId)
 END
END