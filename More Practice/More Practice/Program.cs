using System;

namespace More_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite animal");
            var a = Console.ReadLine();
            if (a == "penguin")
            {
                Console.WriteLine("You guessed it!");
            } else
            {
                Console.WriteLine("Nope!");
            }
        }
    }
}
