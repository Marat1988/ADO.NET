USE MailingLists;
GO

/*Отображение списка акционных товаров*/
CREATE PROCEDURE up_sel_ShowInfoStockProduct
AS
SELECT ls.LineStockId, ls.StockId, ls.Price, p.ProductId, ls.ProductId, p.Name 
FROM LineStock ls 
INNER JOIN Product p ON ls.ProductId = p.ProductId 
INNER JOIN Stock s ON ls.StockId = s.StockId 
ORDER BY p.Name, ls.StockId
GO