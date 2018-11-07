using System;
using System.Collections;
using System.Collections.Generic;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu vertonen.
            Dictionary<string, double> menu = new Dictionary<string, double>();
            menu.Add("plat water", 1);
            menu.Add("cola 25cl", 1.5);
            menu.Add("cola 33cl", 2);
            menu.Add("witte wijn", 3);
            menu.Add("pils", 2);
            menu.Add("toast", 5);
            menu.Add("kaasplank", 4);

            Console.WriteLine("het menu");
            foreach(var menulist  in menu){
                Console.WriteLine(menulist.Key + "\t" + menulist.Value);
            }

            //Gesorteerd menu vetertonen.
            SortedDictionary<string, double> sortedMenu = new SortedDictionary<string, double>();
            sortedMenu.Add("plat water", 1);
            sortedMenu.Add("cola 25cl", 1.5);
            sortedMenu.Add("cola 33cl", 2);
            sortedMenu.Add("witte wijn", 3);
            sortedMenu.Add("pils", 2);
            sortedMenu.Add("toast", 5);
            sortedMenu.Add("kaasplank", 4);

            Console.WriteLine();
            Console.WriteLine("het gesorteerd menu");
            foreach(var menulist  in sortedMenu){
                Console.WriteLine(menulist.Key + "\t" + menulist.Value);
            }

            //Kiezen van artiekel.
            Console.WriteLine("kies uw bestelling");
            string bestelling = Console.ReadLine();
            Console.WriteLine("u koos voor " + bestelling);
            Console.WriteLine("dit kost " + sortedMenu[bestelling]+" euro");
        }
    }
}
