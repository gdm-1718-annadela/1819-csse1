using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //Faculteit
            int getal=10;
            int fac = getal;
            while(getal >2){
                getal -= 1;
                fac *= getal;
            };
            Console.WriteLine("De faculteit van het ingevoerde getal is " + fac);

            //Rij van Fibonacci
            int firstNum=0;
            int sum=1;
            for(int fib = 0; fib<10; fib++){
                sum = firstNum + sum;
                Console.WriteLine(firstNum);
                Console.WriteLine(sum);
                firstNum= firstNum + sum;
                // secondNum++;
                
            }

        }
    }
}
