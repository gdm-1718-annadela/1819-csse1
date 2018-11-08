using System;
using System.Collections;
using System.Collections.Generic;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 1
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

                // Console.WriteLine();
                // Console.WriteLine("het gesorteerd menu");
                // foreach(var menulist  in sortedMenu){
                //     Console.WriteLine(menulist.Key + "\t" + menulist.Value);
                // }

                //Kiezen van artiekel.
                // Console.WriteLine("kies uw bestelling");
                // string bestelling = Console.ReadLine();
                // Console.WriteLine("u koos voor " + bestelling);
                // Console.WriteLine("dit kost " + sortedMenu[bestelling]+" euro");
                // Console.WriteLine();
            //Opdracht2
                Console.WriteLine("lijst van nog niet bediende klanten");
                Queue list = new Queue();
                    list.Enqueue("Anna");
                    list.Enqueue("Bert");
                    list.Enqueue("Ciel");
                    list.Enqueue("Dries");
                    list.Enqueue("Eva");
                    list.Enqueue("Frederic");

                for(int i=0; i<6; i++){
                    Console.WriteLine("lijst van nog niet bediende klanten");
                    foreach(Object obj in list){
                        
                        Console.WriteLine(obj);  
                    }
                    list.Dequeue();
                    Console.WriteLine();
                // }
            }
        }
    }
}
