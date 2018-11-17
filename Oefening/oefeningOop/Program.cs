using System;

namespace oefeningOop
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;
        }

        class Dog: Animal
        {
            public int spotCount;
            public void Bark()
            {
                Console.WriteLine("Wuf");
            }
        }

        class Cat: Animal
        {
            public float cutness;
            public void Meow()
            {
                Console.WriteLine("Meauww");
            }
        }
        static void Main(string[] args)
        {
            Animal dier = new Animal();
            Console.WriteLine(dier.name);
        }
    }
}
