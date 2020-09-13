using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, or else!");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age, or else!");
            string age = Console.ReadLine();
            Console.WriteLine("How's if goin', " + name + "? You are: " + age);
        }
    }
}
