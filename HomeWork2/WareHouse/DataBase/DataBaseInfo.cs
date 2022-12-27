using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WareHouse
{
    public static class DataBaseInfo
    {
        private static SqlConnection conn = new SqlConnection();

        private static void OpenDataBase()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            conn.Open();
            if (conn != null)
                Console.WriteLine("Подключение успешно установлено!");
        }

        private static void RunSql(string sql, string desctiprion, out int rowCount)
        {
            rowCount = 0;
            SqlDataReader rdr = null;
            try
            {
                OpenDataBase();
                Console.WriteLine("\n" + desctiprion);
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Console.Write((rdr.FieldCount > 1) ? rdr[i] + " | " : rdr[i]);
                    }
                    rowCount++;
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                rdr?.Close();
                conn?.Close();
            }
        }

        #region Товары
        //Процедура добавление, удаление, изменения товара
        private static void RunProcedureInsertUpdateDeleteProduct(int ProductId, string Name, int Balance, decimal CostPrice, DateTime LastDateDelivery, int TypeProductId, int SupplierId)
        {
            try
            {
                OpenDataBase();
                SqlCommand cmd = new SqlCommand("up_upd_InsertUpdateDeleteProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = ProductId;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
                cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = Balance;
                cmd.Parameters.Add("@CostPrice", SqlDbType.Decimal).Value = CostPrice;
                cmd.Parameters.Add("@LastDateDelivery", SqlDbType.Date).Value = LastDateDelivery.Date;
                cmd.Parameters.Add("@TypeProductId", SqlDbType.Int).Value = TypeProductId;
                cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = SupplierId;
                SqlParameter outParam = new SqlParameter("@LineAnswer", SqlDbType.VarChar, 1000);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@LineAnswer"].Value.ToString().Length > 0)
                    Console.WriteLine(cmd.Parameters["@LineAnswer"].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }
        //Информация о товарах
        public static void InfoProducts()
        {
            RunSql("SELECT * FROM vw_InfoProducts", "Информация о товарах", out _);
        }
        //Добавление товара
        public static void InsertProduct()
        {
            try
            {
                RunSql("SELECT * FROM Suppliers", "Таблица поставщиков", out int countSupplier);
                Console.WriteLine("--------------------------------------");
                RunSql("SELECT * FROM TypeProduct", "Таблица типов товара", out int countTypeProduct);
                if (countSupplier==0 || countTypeProduct == 0)
                {
                    Console.WriteLine("Добавление новых товаров не возможна, т.к. не существуют поставщиков или типов товара");
                }
                else
                {
                    Console.Write("Введите название товара: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите остаток товара: ");
                    int balance = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите себестоимость товара: ");
                    decimal costPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Введите последнюю дату поставки товара: ");
                    DateTime lastDateDelivery = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Введите id типа товара: ");
                    int typeProductId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите id поставщика: ");
                    int supplierId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteProduct(0, name, balance, costPrice, lastDateDelivery, typeProductId, supplierId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Обновление информации о товаре
        public static void UpdateProduct()
        {
            try
            {
                RunSql("SELECT * FROM Products", "Таблица товаров", out int countProducts);
                Console.WriteLine("--------------------------------------");
                RunSql("SELECT * FROM Suppliers", "Таблица поставщиков", out int countSupplier);
                Console.WriteLine("--------------------------------------");
                RunSql("SELECT * FROM TypeProduct", "Таблица типов товара", out int countTypeProduct);
                if (countProducts==0|| countSupplier == 0 || countTypeProduct == 0)
                {
                    Console.WriteLine("Обновление информации о товаре не возможна, т.к. не существуют поставщиков или типов товара или товаров");
                }
                else
                {
                    Console.Write("ВВедите id товара, информацию о котором вы хотите обновить: ");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новое название товара: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите новый остаток товара: ");
                    int balance = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новую себестоимость товара: ");
                    decimal costPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Введите новую последнюю дату поставки товара: ");
                    DateTime lastDateDelivery = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Введите новый id типа товара: ");
                    int typeProductId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новый id поставщика: ");
                    int supplierId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteProduct(productId, name, balance, costPrice, lastDateDelivery, typeProductId, supplierId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Удаление товара
        public static void DeleteProduct()
        {
            try
            {
                RunSql("SELECT * FROM Products", "Таблица товаров", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id товара, который вы хотите удалить: ");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteProduct(productId * -1, "", 0, 0, DateTime.Now, 1, 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Поставщики
        //Процедура добавление, удаление, изменения поставщика
        private static void RunProcedureInsertUpdateDeleteSupplier(int SupplierId, string Name)
        {
            try
            {
                OpenDataBase();
                SqlCommand cmd = new SqlCommand("up_upd_InsertUpdateDeleteSupplier", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = SupplierId;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
                SqlParameter outParam = new SqlParameter("@LineAnswer", SqlDbType.VarChar, 1000);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@LineAnswer"].Value.ToString().Length > 0)
                    Console.WriteLine(cmd.Parameters["@LineAnswer"].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }
        //Информация о поставщиках
        public static void InfoSupplier()
        {
            RunSql("SELECT * FROM Suppliers", "Таблица поставщиков", out _);
        }
        //Добавление поставщика
        public static void InsertSupplier()
        {
            Console.Write("Введите название поставщика: ");
            string name = Console.ReadLine();
            RunProcedureInsertUpdateDeleteSupplier(0, name);
        }
        //Обновление инфориации о поставщике
        public static void UpdateSupplier()
        {
            try
            {
                RunSql("SELECT * FROM Suppliers", "Таблица поставщиков", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id поставщика, информацию о котором вы хотите изменить: ");
                    int supplierId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новое название поставщика: ");
                    string name = Console.ReadLine();
                    RunProcedureInsertUpdateDeleteSupplier(supplierId, name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Удаление поставщика
        public static void DeleteSupplier()
        {
            try
            {
                RunSql("SELECT * FROM Suppliers", "Таблица поставщиков", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id поставщика, которого вы хотите удалить: ");
                    int supplierId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteSupplier(supplierId * -1, "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Типы товаров
        //Процедура добавление, удаление, изменения поставщика
        private static void RunProcedureInsertUpdateDeleteTypeProduct(int TypeProductId, string Name)
        {
            try
            {
                OpenDataBase();
                SqlCommand cmd = new SqlCommand("up_upd_InsertUpdateDeleteTypeProduct", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TypeProductId", SqlDbType.Int).Value = TypeProductId;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
                SqlParameter outParam = new SqlParameter("@LineAnswer", SqlDbType.VarChar, 1000);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam).Value = "";
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@LineAnswer"].Value.ToString().Length > 0)
                    Console.WriteLine(cmd.Parameters["@LineAnswer"].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }
        //Информация о типах товаров
        public static void InfoTypeProduct()
        {
            RunSql("SELECT * FROM TypeProduct", "Таблица типа товаров", out _);
        }
        //Добавление типа товара
        public static void InsertTypeProduct()
        {
            Console.Write("Введите наименование типа товара: ");
            string name = Console.ReadLine();
            RunProcedureInsertUpdateDeleteTypeProduct(0, name);
        }
        //Обновление типа товара
        public static void UpdateTypeProduct()
        {
            try
            {
                RunSql("SELECT * FROM TypeProduct", "Таблица типа товаров", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id типа продукта, который вы хотите изменить: ");
                    int typeProductId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новое название товара: ");
                    string name = Console.ReadLine();
                    RunProcedureInsertUpdateDeleteTypeProduct(typeProductId, name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Удаление типа товара
        public static void DeleteTypeProduct()
        {
            try
            {
                RunSql("SELECT * FROM TypeProduct", "Таблица типа товаров", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id типа продукта, который вы хотите удалить: ");
                    int typeProductId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteTypeProduct(typeProductId * -1, "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Показать информацию о поставщике с наибольшим количеством товаров на складе
        public static void InfoSupplierBigCountProduct()
        {
            RunSql("SELECT TOP 1 [Supplier name], COUNT([Name product]) AS [Count product] FROM vw_InfoProducts GROUP BY [Supplier name] ORDER BY 2 DESC", "Поставщик с наибольшим количеством товара", out _);
        }
        #endregion

        #region Показать информацию о поставщике с наименьшим количеством товаров на складе
        public static void InfoSupplierLittleCountProduct()
        {
            RunSql("SELECT TOP 1 [Supplier name], COUNT([Name product]) AS [Count product] FROM vw_InfoProducts GROUP BY [Supplier name] ORDER BY 2", "Поставщик с наименьшим количеством товара", out _);
        }
        #endregion

        #region Показать информацию о типе товаров с наибольшим количеством товаров на складе
        public static void InfoTypeProductrBigCountProduct()
        {
            RunSql("SELECT TOP 1 [Type product name], COUNT([Name product]) AS [Count product] FROM vw_InfoProducts GROUP BY [Type product name] ORDER BY 2 DESC", "Тип товара с наибольшим количеством товара", out _);
        }
        #endregion

        #region Показать информацию о типе товаров с наименьшим количеством товаров на складе
        public static void InfoTypeProductrLittleCountProduct()
        {
            RunSql("SELECT TOP 1 [Type product name], COUNT([Name product]) AS [Count product] FROM vw_InfoProducts GROUP BY [Type product name] ORDER BY 2", "Тип товара с наименьшим количеством товара", out _);
        }
        #endregion

        #region Показать товары с поставки, которых прошло заданное количество дней
        public static void InfoProductDeliveryPassedNumberDays()
        {
            try
            {
                Console.Write("Введите количество дней: ");
                int countDays = Convert.ToInt32(Console.ReadLine());
                RunSql($"SELECT * FROM vw_InfoProducts WHERE DATEDIFF(dd,[Last date delivery], GETDATE())>={countDays}", $"Информация о товарах, с поставки которых прошло больше либо равно {countDays} дней", out _);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
