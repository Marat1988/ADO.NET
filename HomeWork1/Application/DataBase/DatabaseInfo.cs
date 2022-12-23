using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            conn.Open();
            if (conn != null)
                Console.WriteLine("Подключение успешно установлено!\n");
        }
        private static void RunStorecProc(string nameProcedure)
        {
            try
            {
                OpenDataBase();
                SqlCommand cmd = new SqlCommand(nameProcedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                Console.Write("Введите цвет: ");
                cmd.Parameters.Add("@Color", SqlDbType.VarChar).Value = Console.ReadLine();
                SqlParameter outParam = new SqlParameter("@CountProduct", SqlDbType.Int);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);
                cmd.ExecuteNonQuery();
                Console.WriteLine(cmd.Parameters["@CountProduct"].Value.ToString());
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
        private static void RunSql(string sql)
        {
            SqlDataReader rdr = null;
            try
            {
                OpenDataBase();
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
            // RunSql("SELECT COUNT(*) FROM TypeProducts tp INNER JOIN Product p ON tp.TypeProductId = p.TypeProductId WHERE tp.TypeProductId = 2");
            RunSql("DELETE FROM TypeProducts WHERE TypeProductId = 2");
        }
        #endregion
        public static void ShowInfoProductColor()
        {

        }

        #region Показать количество овощей и фруктов заданного цвета
        public static void ShowInfoProductColorCount()
        {
            RunStorecProc("up_sel_ShowInfoProductColorCount");
        }
        #endregion

        #region Показать количество овощей фруктов каждого цвета
        public static void CountVegetablesFruitsEveryoneColor()
        {
            RunSql("SELECT p.Color, COUNT(CASE WHEN tp.TypeProductId=1 THEN p.Id END) AS [Count vegetable], COUNT(CASE WHEN tp.TypeProductId = 2 THEN p.Id END) AS [Count fruit] FROM TypeProducts tp INNER JOIN Product p ON tp.TypeProductId = p.TypeProductId GROUP BY p.Color");
        }
        #endregion

        #region Показать овощи и фрукты с калорийностью ниже указанной
        public static void ShowInfoCaloricBelowSpecified()
        {
            Console.Write("Введите значение калорийности ");
            if (int.TryParse(Console.ReadLine(), out int caloric))
                RunSql("SELECT * FROM vw_ShowInfoProduct WHERE Caloric<" + caloric);
            else
                Console.WriteLine("Не корректный ввод");
        }
        #endregion

        #region Показать овощи и фрукты с калорийностью выже указанной
        public static void ShowInfoCaloricAboveSpecified()
        {
            Console.Write("Введите значение калорийности ");
            if (int.TryParse(Console.ReadLine(), out int caloric))
                RunSql("SELECT * FROM vw_ShowInfoProduct WHERE Caloric>" + caloric);
            else
                Console.WriteLine("Не корректный ввод");
        }
        #endregion

        #region Показать овощи и фрукты с калорийностью в указанном диапазоне
        public static void ShowInfoCaloricBetweenRange()
        {
            try
            {
                Console.Write("Введите начало дианазона ");
                int BeginRange = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите конец дианазона ");
                int EndRange = Convert.ToInt32(Console.ReadLine());
                RunSql("SELECT * FROM vw_ShowInfoProduct WHERE Caloric BETWEEN " + BeginRange + " AND " + EndRange);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Показать все овощи и фрукты, у которых цвет желтый или красный
        public static void ShowInfoColorProductYellowOrRed()
        {
            RunSql("SELECT * FROM vw_ShowInfoProduct WHERE Color = 'Желтый' OR Color = 'Красный'");
        }
        #endregion

    }
}
