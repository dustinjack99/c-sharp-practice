using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassCalculator
    {
        public void Calculator()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.Write(num1 + num1);
            } else if (op == "-")
            {
                Console.Write(num1 - num2);
            } else if (op == "*")
            {
                Console.Write(num1 * num2);
            } else if (op == "/")
            {
                Console.Write(num1 / num2);
            } else
            {
                Console.WriteLine("Invalid Operation")
            }

            Console.WriteLine(GetMax(304, 601, 506));
        }

        private int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3) {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
        }

        private 
    }
}
