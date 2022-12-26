using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Домашняя работа №2";
            ConsoleMenu menu = new ConsoleMenu("Главное меню");

            menu.AddMenu("Инфомация о типах товаров", DataBaseInfo.InfoTypeProduct);
            menu.AddMenu("Вставка новых типов товаров", DataBaseInfo.InsertTypeProduct);
            menu.AddMenu("Обновление информации о существующих типах товаров", DataBaseInfo.UpdateTypeProduct);
            menu.AddMenu("Удаление типов товаров", DataBaseInfo.DeleteTypeProduct);

            menu.AddMenu("Информация о поставщиках", DataBaseInfo.InfoSupplier);
            menu.AddMenu("Вставка новых поставщиков", DataBaseInfo.InsertSupplier);
            menu.AddMenu("Обновление информации о существующих поставщиках", DataBaseInfo.UpdateSupplier);
            menu.AddMenu("Удаление поставщиков", DataBaseInfo.DeleteSupplier);

            menu.AddMenu("Информация о товарах", DataBaseInfo.InfoProducts);
            menu.AddMenu("Вставка новых товаров", DataBaseInfo.InsertProduct);
            menu.AddMenu("Обновление информации о существующих товарах", DataBaseInfo.UpdateProduct);
            menu.AddMenu("Удаление товаров", DataBaseInfo.DeleteProduct);

            menu.AddMenu("Показать информацию о поставщике с наибольшим количеством товаров на складе", DataBaseInfo.InfoSupplierBigCountProduct);
            menu.AddMenu("Показать информацию о поставщике с наименьшим количеством товаров на складе", DataBaseInfo.InfoSupplierLittleCountProduct);
            menu.AddMenu("Показать информацию о типе товаров с наибольшим количеством товаров на складе", DataBaseInfo.InfoTypeProductrBigCountProduct);
            menu.AddMenu("Показать информацию о типе товаров с наименьшим количеством товаров на складе", DataBaseInfo.InfoTypeProductrLittleCountProduct);
            menu.AddMenu("Показать товары с поставки, которых прошло заданное количество дней", DataBaseInfo.InfoProductDeliveryPassedNumberDays);

            menu.ShowMenu();

        }
    }
}
