using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public static class DatabaseInfo
    {
        private static SqlConnection conn = new SqlConnection();
        private static void OpenDataBase()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        private static void RunSql(string sql)
        {
            SqlDataReader rdr = null;
            try
            {
                OpenDataBase();
                conn.Open();
                if (conn != null)
                    Console.WriteLine("Подключение успешно установлено!\n");
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {

                        Console.Write((rdr.FieldCount > 1) ? rdr[i] + " | " : rdr[i]);
                    }
                    Console.WriteLine();
                }
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

        #region Отображение всей информации из таблицы с овощами и фруктами
        public static void ShowInfoProducts()
        {
            RunSql("SELECT * FROM vw_ShowInfoProduct");
        }
        #endregion
        #region Отображение всех названий овощей и фруктов
        public static void ShowInfoNameProduct()
        {
            RunSql("SELECT [Name product] FROM vw_ShowInfoProduct");
        }
        #endregion
        #region Отображение всех цветов
        public static void ShowInfoColor()
        {
            RunSql("SELECT DISTINCT Color FROM vw_ShowInfoProduct");
        }
        #endregion
        #region Показать максимальную калорийность"
        public static void ShowInfoMaxCaloric()
        {
            RunSql("SELECT MAX(Caloric) FROM vw_ShowInfoProduct");
        }
        #endregion
        #region Показать минимальную калорийность
        public static void ShowInfoMinCaloric()
        {
            RunSql("SELECT MIN(Caloric) FROM vw_ShowInfoProduct");
        }
        #endregion
        #region Показать среднюю калорийность
        public static void ShowInfoAvgCaloric()
        {
            RunSql("SELECT AVG(Caloric) FROM vw_ShowInfoProduct");
        }
        #endregion
        #region Показать количество овощей
        public static void ShowInfoCountVeggie()
        {
            RunSql("SELECT COUNT(*) FROM TypeProducts tp INNER JOIN Product p ON tp.TypeProductId = p.TypeProductId WHERE tp.TypeProductId = 1");
        }
        #endregion
        #region Показать количество фруктов
        public static void ShowInfoCountFruit()
        {
            RunSql("SELECT COUNT(*) FROM TypeProducts tp INNER JOIN Product p ON tp.TypeProductId = p.TypeProductId WHERE tp.TypeProductId = 2");
        }
        #endregion


    }
}
