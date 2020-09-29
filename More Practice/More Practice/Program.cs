using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace More_Practice
{

    
    class Program
    {
        static void Main (string[] args)
        {
            var x = 2;
            Console.WriteLine(x);

            Double(ref x);

            Console.WriteLine(x);
        }

            //out keyword lets us use the referenced variable outside of a function
        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        //ref keyword also lets us initialize the value of outside variable
        static void Double(ref int a)
        {
            a = a * 2;
            Console.WriteLine(a);
        }
    }
}

