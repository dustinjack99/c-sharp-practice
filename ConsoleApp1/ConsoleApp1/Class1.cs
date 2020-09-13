using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassCalculator
    {
        public void Calculator()
        {
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(num1 + num2);

        }
    }
}
