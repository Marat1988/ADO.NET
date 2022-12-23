using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork1
{
    class WareHous
    {
        private static SqlConnection conn = new SqlConnection();

        static void Main(string[] args)
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            Console.Title = "Домашняя работа №1";
            ConsoleMenu menu = new ConsoleMenu("Главное меню");
            menu.AddMenu("Отображение всей информации из таблицы с овощами и фруктами", ShowInfoProducts);
            menu.AddMenu("Отображение всех названий овощей и фруктов", ShowInfoNameProduct);
            menu.AddMenu("Отображение всех цветов", ShowInfoColor);
            menu.AddMenu("Показать максимальную калорийность", ShowInfoMaxCaloric);
            menu.AddMenu("Показать минимальную калорийность", ShowInfoMinCaloric);
            menu.AddMenu("Показать среднюю калорийность", ShowInfoAvgCaloric);
            menu.ShowMenu();
        }
        private static void ShowInfoProducts()
        {
            Console.WriteLine("Отображение всей информации из таблицы с овощами и фруктами");
        }
        private static void ShowInfoNameProduct()
        {
            Console.WriteLine("Отображение всех названий овощей и фруктов");
        }
        private static void ShowInfoColor()
        {
            Console.WriteLine("Отображение всех цветов");
        }
        private static void ShowInfoMaxCaloric()
        {
            Console.WriteLine("Показать максимальную калорийность");
        }
        private static void ShowInfoMinCaloric()
        {
            Console.WriteLine("Показать минимальную калорийность");
        }
        private static void ShowInfoAvgCaloric()
        {
            Console.WriteLine("Показать среднюю калорийность");
        }
    }
}
