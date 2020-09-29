using System;
using System.Collections.Generic;
using System.Text;

namespace More_Practice
{
    class Teacher : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}
