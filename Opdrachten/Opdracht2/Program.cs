using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alle tafels
            for(int getaltafel =0; getaltafel<11; getaltafel++){
                Console.WriteLine("tafel van " + getaltafel);
                for(int getaltafeltwee = 0; getaltafeltwee< 11; getaltafeltwee ++){
                    Console.WriteLine(getaltafel + " x "+  getaltafeltwee + " = " + getaltafel * getaltafeltwee);
                }
            }
            //Tafel van gekozen getal.
            Program program = new Program();
            Console.WriteLine("kies een getal voor uw tafel te kiezen");
            int tafelVan = Convert.ToInt32(Console.ReadLine());
            program.Tafel(tafelVan);

            //Faculteit van gekozen getal.
            Console.WriteLine("kies getal voor uw faculteit te verkrijgen");
            int getal = Convert.ToInt32(Console.ReadLine());
            program.Faculteit(getal);

            //Rij van Fibonacci tot gekozen getal.
            Console.WriteLine("kies uw limiet");
            int getalFib = Convert.ToInt32(Console.ReadLine());
            program.Fibonacci(getalFib);
        }
            void Tafel(int tafelgetal){
            Console.WriteLine("De tafel van " + tafelgetal);
            for(int firstNum = 0; firstNum<11; firstNum++){
                int resultaat = firstNum * tafelgetal;
                Console.WriteLine(firstNum + " x " + tafelgetal + " = " + resultaat);
                }
            }

            void Faculteit(int getal){
                int fac = getal;
                while(getal >2){
                    getal -= 1;
                    fac *= getal;
                };
            Console.WriteLine("De faculteit van het ingevoerde getal is " + fac);
            }

            void Fibonacci(int getalFib){
                int firstNumFib=0;
                int sum=1;
                for(int fib = 0; fib<getalFib; fib++){
                    sum = firstNumFib + sum;
                    Console.WriteLine(firstNumFib);
                    Console.WriteLine(sum);
                    firstNumFib= firstNumFib + sum;
                }
            }
        }
    }

