using System;

namespace Deel3
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseConection d1 = DbConection.GetDbConection();
            DatabaseConection d2 = DbConection.GetDbConection();

            if(d1 == d2){
                Console.WriteLine("zelfde aanleg");
            }

            DatabaseConection database = DatabaseConection.GetDbConection();
            for(int i=0; i<10; i++){
                string server = database.Server;
                Console.WriteLine("vraag request aan: " +server);

                Console.ReadKey();
            }
        }
    }
}
