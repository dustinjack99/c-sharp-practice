using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef Makes Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef Makes Salad");
        }

        //Add virtual to override inherited method
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef Makes BBQ Ribs");
        }
    }
}
