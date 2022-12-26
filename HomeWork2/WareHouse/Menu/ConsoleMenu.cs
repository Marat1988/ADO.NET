using System;
using System.Collections.Generic;
using System.Linq;

namespace WareHouse
{
    public class ConsoleMenu
    {
        private string Title = "Главное меню";
        private readonly List<MenuItem> menuItems = new List<MenuItem>();

        public ConsoleMenu(string Title)
        {
            this.Title = (Title.Length == 0) ? "Главное меню" : Title;
        }

        public void AddMenu(string text, Action method)
        {
            int maxId = (menuItems.Count == 0) ? 0 : menuItems.Max(menuItems => menuItems.Id);
            menuItems.Add(new MenuItem(maxId + 1, text, method));
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(Title + "\n");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine("Наберите " + menuItems[i].Id + " для действия: " + menuItems[i].Description);
            }
            Console.WriteLine();
            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out int command))
                {
                    if (menuItems.Any(menuItems => menuItems.Id == command))
                        ShowInfo(command);
                    else
                        Console.WriteLine("Не верно набранная команда");
                }
            }
        }

        public void ShowInfo(int command)
        {
            Console.Clear();
            int index = menuItems.FindLastIndex(menuItems => menuItems.Id == command);
            menuItems[index].Delegate?.Invoke();
            Console.WriteLine("\nДля выхода нажмите любую клавишу..........");
            Console.ReadKey(true);
            ShowMenu();
        }

    }
}
