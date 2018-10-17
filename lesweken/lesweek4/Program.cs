using System;

namespace lesweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //formule oplossen
                int a1= 100;
                int a2 = 7;
                int a3 = a1 + a2;
                int a4 = 3;
                int blockA = a3 * a4;

                int b1 = 5;
                int b2 = 406;
                int b3 = 7367;
                int b4 = b2 + b3;
                int b5 = 69;
                int b6 = b4 / b5;
                int blockB = b1 * b6;

                int c1 = 73;
                int c2 = 41;
                int c3 = c1 * c2;
                int c4 = 39;
                int blockC = c3 - c4;

                int d1 = 7;
                int d2 = 8;
                int d3 = d1 * d2;
                int d4 = 19;
                int blockD = d3 - d4;

                int blockE = blockA + blockB + blockC + blockD;

                // Console.WriteLine("Het resultaat is: " + blockE);


                //reduceren
                int resultaat1 = optellen (100,7);
                int resultaat2 = vermeerderen(resultaat1, 3);

                int resultaat3 = optellen (406, 7367);
                int resultaat4 = deling(resultaat3, 69);
                int resultaat5 = vermeerderen(5, resultaat4);

                int resultaat6 = vermeerderen(73, 41);
                int resultaat7 = verminderen(resultaat6, 39);

                int resultaat8 = vermeerderen(7, 8);
                int resultaat9 = verminderen(resultaat8, 19);

                int totaal = totaalOptelling(resultaat2, resultaat5, resultaat7, resultaat9);

                // Console.WriteLine("korter resultaat: " + totaal);

                //reduceren stap2
                int resultaatb2 = vermeerderen(optellen (100,7), 3);
                int resultaatb5 = vermeerderen(5, deling(optellen (406, 7367), 69));
                int resultaatb7 = verminderen(vermeerderen(73, 41), 39);
                int resultaatb9 = verminderen(vermeerderen(7, 8), 19);

                // int totaal2 = resultaatb2 + resultaatb5 + resultaatb7 + resultaatb9;

                //reduceren stap3
                int totaal3 = vermeerderen(optellen (100,7), 3) + vermeerderen(5, deling(optellen (406, 7367), 69)) + verminderen(vermeerderen(73, 41), 39) + verminderen(vermeerderen(7, 8), 19);

                // Console.WriteLine("nog korter: " + totaal3);

                //Reduceren Correcte manier
                    //dit is een sequentie/opeenvolging. Eerst dit, ten 2de dat,...
                    int totaal4 = optellen (optellen(optellen(vermeerderen(optellen (100,7), 3), vermeerderen(5, deling(optellen (406, 7367), 69))), verminderen(vermeerderen(73, 41), 39)), verminderen(vermeerderen(7, 8), 19));
                    Console.WriteLine("correct antwoord met achterliggende code: "+totaal4);

                //if-statement
                // totaal4--; //test of if else statement werkt

                if(totaal4 == 3872)
                {
                    Console.WriteLine("Het resultaat is perfect");
                }
                else if (totaal4 > 3872)
                {
                    Console.WriteLine("Het resultaat is te hoog");
                }
                else
                {
                    Console.WriteLine("Het resultaat is te laag");
                }

                //forloop
                for(int i= 0; i < 11; i++){
                    Console.WriteLine("De teller is nu " + i);
                }

                for(int firstNum =0; firstNum<11; firstNum++){
                    Console.WriteLine("tafel van" + firstNum);
                    for(int secondNum = 0; secondNum< 11; secondNum ++){
                        Console.WriteLine(firstNum + " x "+  secondNum + " = " + firstNum * secondNum);
                    }
                }

                //do while
                int getal = 3;
                do
                {
                    Console.WriteLine("De waarde van het getal is:  "+ getal);
                    getal++;
                }while(getal < 5);

                //while
                int getal2 = 4;
                while(getal2 < 5)
                {
                    Console.WriteLine("De waarde van het getal2 is:  "+ getal2);
                    getal2++;
                }
        }

        static int optellen(int a, int b)
        {
            return a + b;
        }

        static int verminderen(int a, int b)
        {
            return a - b;
        }

        static int deling(int a, int b)
        {
            return a / b;
        }

        static int vermeerderen(int a, int b)
        {
            return a * b;
        }

        static int totaalOptelling (int a, int b, int c, int d){
            return a + b + c + d;
        }
    }
}
