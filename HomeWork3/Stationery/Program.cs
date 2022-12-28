using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    class Program
    {
        static void Main(string[] args)
        {
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


            menu.ShowMenu();
        }
    }
}
