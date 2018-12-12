using System;

namespace Deel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Menuitem product1 = new Menuitem();
            product1.Product = "computer muis";
            Console.WriteLine(product1.ToString());

            Price price1= new Price();
            price1.Waarde = 10;
            price1.Valuta = "euro";
        }
    }
}

//ANTWOORDEN VRAGEN
/*
1.  Menuitem is basis klasse. Price en Product zijn subklasses.
 */