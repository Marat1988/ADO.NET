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
            menu.AddMenu("Показать количество овощей и фруктов заданного цвета", DatabaseInfo.ShowInfoProductColorCount);
            menu.AddMenu("Показать количество овощей фруктов каждого цвета", DatabaseInfo.CountVegetablesFruitsEveryoneColor);
            menu.AddMenu("Показать овощи и фрукты с калорийностью ниже указанной", DatabaseInfo.ShowInfoCaloricBelowSpecified);
            menu.AddMenu("Показать овощи и фрукты с калорийностью выже указанной", DatabaseInfo.ShowInfoCaloricAboveSpecified);
            menu.AddMenu("Показать овощи и фрукты с калорийностью в указанном диапазоне", DatabaseInfo.ShowInfoCaloricBetweenRange);
            menu.AddMenu("Показать все овощи и фрукты, у которых цвет желтый или красный", DatabaseInfo.ShowInfoColorProductYellowOrRed);
            menu.AddMenu("Выход из программы", ExitProgram);
            menu.ShowMenu();
        }

        static void ExitProgram() => Environment.Exit(0);
    }
}
