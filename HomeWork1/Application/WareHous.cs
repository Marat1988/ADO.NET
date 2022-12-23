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
        static void Main(string[] args)
        {
            Console.Title = "Домашняя работа №1";
            ConsoleMenu menu = new ConsoleMenu("Главное меню");
            menu.AddMenu("Отображение всей информации из таблицы с овощами и фруктами", DatabaseInfo.ShowInfoProducts);
            menu.AddMenu("Отображение всех названий овощей и фруктов", DatabaseInfo.ShowInfoNameProduct);
            menu.AddMenu("Отображение всех цветов", DatabaseInfo.ShowInfoColor);
            menu.AddMenu("Показать максимальную калорийность", DatabaseInfo.ShowInfoMaxCaloric);
            menu.AddMenu("Показать минимальную калорийность", DatabaseInfo.ShowInfoMinCaloric);
            menu.AddMenu("Показать среднюю калорийность", DatabaseInfo.ShowInfoAvgCaloric);

            menu.AddMenu("Показать количество овощей", DatabaseInfo.ShowInfoCountVeggie);
            menu.AddMenu("Показать количество фруктов", DatabaseInfo.ShowInfoCountFruit);

            menu.ShowMenu();
        }
    }
}
