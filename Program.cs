using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek1
{
    class Program
    {
        private static int index = 0;
        
        static void Main(string[] args)
        {
            
            var menu = new menu(); 
            
            List<string> menuItem = new List<string>()
            {
                "Menu",
                "Transaksi",
                "Exit"
            };
            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuitem = drawMenu(menuItem);

                if (selectedMenuitem == "Menu")
                {
                    Console.Clear();
                    Console.WriteLine("$Bakso: {Name}" + "$15000: {Harga}" + "$true: {Status}");
                }
                else if (selectedMenuitem == "Exit")
                {
                    Environment.Exit(0);
                }
                    
            }
        }

        private static string drawMenu(List<string> menuItem)
        {
            for (int i = 0; i < menuItem.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(menuItem[i]);
                }
                else
                {
                    Console.WriteLine(menuItem[i]); 
                }
                Console.ResetColor(); 
            }
            
            ConsoleKeyInfo ckey = Console.ReadKey();

            if(ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == menuItem.Count - 1)
                {
                    //index = 0;
                } else
                {
                    index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1;
                } else
                {
                    index--;
                }
            } else if (ckey.Key == ConsoleKey.Enter)
            {
                return menuItem[index];
            } else
            {
                return "";
            }
            Console.Clear();
            return "";

        }
    }
}
