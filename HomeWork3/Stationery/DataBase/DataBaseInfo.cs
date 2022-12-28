using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    public static class DataBaseInfo
    {
        private static SqlConnection conn = new SqlConnection();
        private static void OpenDataBase()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            conn.Open();
            if (conn != null)
                Console.WriteLine("Подключение успешно установлено");
        }
        private static void RunSql(string sql, string description, out int rowCount)
        {
            rowCount = 0;
            SqlDataReader rdr = null;
            try
            {
                OpenDataBase();
                Console.WriteLine("\n" + description);
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

        #region Типы канцтоваров
        //Процедура добавление, удаление, изменения типа канцтоваров
        private static void RunProcedureInsertUpdateDeleteTypeStationery(int TypeStationeryId, string Name)
        {
            try
            {
                OpenDataBase();
                SqlCommand cmd = new SqlCommand("up_upd_InsertUpdateDeleteTypeStationery", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TypeStationeryId", SqlDbType.Int).Value = TypeStationeryId;
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
        //Информация и типах канцтоваров
        public static void InfoTypeStationery()
        {
            RunSql("SELECT * FROM TypeStationery", "Информация о типах канцтоваров", out _);
        }
        //Добавление нового типа канцтовара
        public static void InsertTypeStationery()
        {
            Console.Write("Введите наименование нового типа канцтовара: ");
            string name = Console.ReadLine();
            RunProcedureInsertUpdateDeleteTypeStationery(0, name);
        }
        //Обновление типа канцтоваров
        public static void UpdateTypeStationery()
        {
            try
            {
                RunSql("SELECT * FROM TypeStationery", "Информация о типах канцтоваров", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id типа канцтовара, который вы хотите изменить: ");
                    int typeStationeryId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новое название канцтовара: ");
                    string name = Console.ReadLine();
                    RunProcedureInsertUpdateDeleteTypeStationery(typeStationeryId, name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Удаление типа канцтовара
        public static void DeleteTypeStationery()
        {
            try
            {
                RunSql("SELECT * FROM TypeStationery", "Информация о типах канцтоваров", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id типа канцтовара, который вы хотите удалить: ");
                    int typeStationeryId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteTypeStationery(typeStationeryId * -1, "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Менеджеры
        //Процедура добавления, удаления, изменения менеджеров
        private static void RunProcedureInsertUpdateDeleteManager(int ManagerId, string Name)
        {
            try
            {
                OpenDataBase();
                SqlCommand cmd = new SqlCommand("up_upd_InsertUpdateDeleteManager", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ManagerId", SqlDbType.Int).Value = ManagerId;
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
        //Информация о менеджерах
        public static void InfoManagers()
        {
            RunSql("SELECT * FROM Manager", "Информация о менеджерах", out _);
        }
        //Добавление нового менеджера
        public static void InsertManager()
        {
            Console.Write("Введите имя нового менеждера: ");
            string name = Console.ReadLine();
            RunProcedureInsertUpdateDeleteManager(0, name);
        }
        //Обновление информации о менеджере
        public static void UpdateManager()
        {
            try
            {
                RunSql("SELECT * FROM Manager", "Информация о менеджерах", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id менеджера, информацию о котором вы хотите изменить: ");
                    int ManagerId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новое ммя менеджера: ");
                    string name = Console.ReadLine();
                    RunProcedureInsertUpdateDeleteManager(ManagerId, name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Удаление менеджера
        public static void DeleteManager()
        {
            try
            {
                RunSql("SELECT * FROM Manager", "Информация о менеджерах", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id менеджера, которого вы хотите удалить: ");
                    int ManagerId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteManager(ManagerId * -1, "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Покупатели
        //Процедура добавления, удаления, изменения покупателей
        private static void RunProcedureInsertUpdateDeleteBuyers(int BuyersId, string Name)
        {
            try
            {
                OpenDataBase();
                SqlCommand cmd = new SqlCommand("up_upd_InsertUpdateDeleteBuyers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@BuyersId", SqlDbType.Int).Value = BuyersId;
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
        //Информация о покупателях
        public static void InfoBuyers()
        {
            RunSql("SELECT * FROM Buyers", "Информация о покупателях", out _);
        }
        //Добавление нового покупателя
        public static void InsertBuyers()
        {
            Console.Write("Введите название нового покупателя: ");
            string name = Console.ReadLine();
            RunProcedureInsertUpdateDeleteBuyers(0, name);
        }
        //Обновление информации о покупателе
        public static void UpdateBuyers()
        {
            try
            {
                RunSql("SELECT * FROM Buyers", "Информация о покупателях", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id покупателя, информацию о котором вы хотите измененить: ");
                    int BuyersId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новое навзание покупателя: ");
                    string name = Console.ReadLine();
                    RunProcedureInsertUpdateDeleteBuyers(BuyersId, name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Удаление покупателя
        public static void DeleteBuyers()
        {
            try
            {
                RunSql("SELECT * FROM Buyers", "Информация о покупателях", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id покупателя, которого вы хотите удалить: ");
                    int BuyersId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteBuyers(BuyersId * -1, "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Канцтовары
        //Процедура добавления, удаления, изменения канцтоваров
        private static void RunProcedureInsertUpdateDeleteStationery(int StationeryId, string Name, decimal CostPrice, int TypeStationeryId)
        {
            try
            {
                OpenDataBase();
                SqlCommand cmd = new SqlCommand("up_upd_InsertUpdateDeleteStationery", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StationeryId", SqlDbType.Int).Value = StationeryId;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
                cmd.Parameters.Add("@CostPrice", SqlDbType.Decimal).Value = CostPrice;
                cmd.Parameters.Add("@TypeStationeryId", SqlDbType.Int).Value = TypeStationeryId;
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
        //Информация о канцтоваров
        public static void InfoStationery()
        {
            RunSql("SELECT * FROM vw_InfoStationery", "Информация о кацтварах", out _);
        }
        //Добавление нового канцтовара
        public static void InsertStationery()
        {
            try
            {
                RunSql("SELECT * FROM TypeStationery", "Информация о типах канцтоваров", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите название нового канцтовара: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите себестоимость канцтовара: ");
                    decimal costPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Введите id типа канцтовара: ");
                    int typeStationeryId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteStationery(0, name, costPrice, typeStationeryId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Изменение нового типа канцтовара
        public static void UpdateStationery()
        {
            try
            {
                RunSql("SELECT * FROM TypeStationery", "Информация о типах канцтоваров", out int rowCountTypeStationery);
                Console.WriteLine();
                RunSql("SELECT * FROM vw_InfoStationery", "Информация канцтоварах", out int rowCountStationery);
                if ((rowCountTypeStationery == 0) || (rowCountStationery == 0))
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id типа канцтовара, информацию о котором вы хотите изменить: ");
                    int idStationery = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите новое название канцтовара: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите новую себестоимость канцтовара: ");
                    decimal costPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Введите новый id типа канцтовара: ");
                    int typeStationeryId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteStationery(idStationery, name, costPrice, typeStationeryId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Удаление канцтоварар
        public static void DeleteStationery()
        {
            try
            {
                RunSql("SELECT * FROM vw_InfoStationery", "Информация канцтоварах", out int rowCount);
                if (rowCount == 0)
                {
                    Console.WriteLine("Нет данных. Продолжение не возможно");
                }
                else
                {
                    Console.Write("Введите Id канцтовара, которой вы хотите удалить: ");
                    int StationeryId = Convert.ToInt32(Console.ReadLine());
                    RunProcedureInsertUpdateDeleteStationery(StationeryId * -1, "", 0, 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        #endregion


    }
}
