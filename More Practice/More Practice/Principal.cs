using System;
using System.Collections.Generic;
using System.Text;

namespace More_Practice
{
    //You can inherit from only one class, but multiple interfaces
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying principal");

        }
    }
}
