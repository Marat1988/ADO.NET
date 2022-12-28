using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        static void Main(string[] args)
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3
            Console.Title = "Домашняя работа №3";
            ConsoleMenu menu = new ConsoleMenu("Главное меню");
            //Типы канцтоваров
            menu.AddMenu("Информация о типах канцтоваров", DataBaseInfo.InfoTypeStationery);
            menu.AddMenu("Вставка новых типов канцтоваров", DataBaseInfo.InsertTypeStationery);
            menu.AddMenu("Обновление информации о существующих типах канцтоваров", DataBaseInfo.UpdateTypeStationery);
            menu.AddMenu("Удаление типов канцтоваров", DataBaseInfo.DeleteTypeStationery);
            //Менеджеры
            menu.AddMenu("Информация о менеджерах", DataBaseInfo.InfoManagers);
            menu.AddMenu("Вставка новых менеджеров по продажам", DataBaseInfo.InsertManager);
            menu.AddMenu("Обновление информации о существующих менеджерах по продажам", DataBaseInfo.UpdateManager);
            menu.AddMenu("Удаление менеджеров по продажам", DataBaseInfo.DeleteManager);
            //Покупатели
            menu.AddMenu("Информация о покупателях", DataBaseInfo.InfoBuyers);
            menu.AddMenu("Вставка новых фирм покупателей", DataBaseInfo.InsertBuyers);
            menu.AddMenu("Обновление информации о существующих фирмах покупателях", DataBaseInfo.UpdateBuyers);
            menu.AddMenu("Удаление фирм покупателей", DataBaseInfo.DeleteBuyers);
            //Канцтовары
            menu.AddMenu("Информация о канцтоварах", DataBaseInfo.InfoStationery);
            menu.AddMenu("Вставка новых канцтоваров", DataBaseInfo.InsertStationery);
            menu.AddMenu("Обновление информации о существующих канцтоварах", DataBaseInfo.UpdateStationery);
            menu.AddMenu("Удаление канцтоваров", DataBaseInfo.DeleteStationery);
            //Запросы
            menu.AddMenu("Показать информацию о менеджере с наибольшим количеством продаж по количеству единиц", DataBaseInfo.BestManagerCountStationery);
            menu.AddMenu("Показать информацию о менеджере по продажам с наибольшей общей суммой прибыли", DataBaseInfo.BestManagerSumProfit);
            menu.AddMenu("Показать информацию о менеджере по продажам с наибольшей общей суммой прибыли за указанный промежуток времени", DataBaseInfo.BestManagerSumProfitDateBetween);
            menu.AddMenu("Показать информацию о фирме покупателе, которая купила на самую большую сумму", DataBaseInfo.BestBuyersSumSales);
            menu.AddMenu("Показать информацию о типе канцтоваров с наибольшим количеством продаж по единицам", DataBaseInfo.BestTypeStationaryCountStationary);
            menu.AddMenu("Показать информацию о типе самых прибыльных канцтоваров", DataBaseInfo.BestTypeStationeryProfit);
            menu.AddMenu("Показать название самых популярных канцтоваров. Популярность высчитываем по количеству проданных единиц", DataBaseInfo.BestStationaryCountStationary);
            menu.AddMenu("Показать название канцтоваров, которые не продавались заданное количество дней", DataBaseInfo.StationaryNoSalesSetCountDays);
            //Выход
            menu.AddMenu("Выход из программы", ExitProgram);


            menu.ShowMenu();
        }
        public static void ExitProgram() => Environment.Exit(0);
    }
}
