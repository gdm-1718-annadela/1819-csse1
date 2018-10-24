using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alle tafels
            for(int firstNum =0; firstNum<11; firstNum++){
                Console.WriteLine("tafel van " + firstNum);
                for(int secondNum = 0; secondNum< 11; secondNum ++){
                    Console.WriteLine(firstNum + " x "+  secondNum + " = " + firstNum * secondNum);
                }

            }
            //Faculteit
            int getal=10;
            int fac = getal;
            while(getal >2){
                getal -= 1;
                fac *= getal;
            };
            Console.WriteLine("De faculteit van het ingevoerde getal is " + fac);

            //Rij van Fibonacci
            int firstNumFib=0;
            int sum=1;
            for(int fib = 0; fib<10; fib++){
                sum = firstNumFib + sum;
                Console.WriteLine(firstNumFib);
                Console.WriteLine(sum);
                firstNumFib= firstNumFib + sum;
                // secondNum++;
                
            }

        }
    }
}
