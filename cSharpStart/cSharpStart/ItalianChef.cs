using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ItalianChef : Chef
    {
        public void GreetChildren()
        {
            Console.WriteLine("Hello Children!");
        }

        //Signify that you are overriding the inherited method
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef Makes South Park School Slop");
        }
    }
}
