using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassIfLesson
    {
        public void IfLesson()
        {
            bool isMale = true;
            bool isTall = true;

            if(isMale && isTall)
            {
                Console.WriteLine("You are tall and male!");
            } else if (isMale && !isTall) {
                Console.WriteLine("You're male, but you ain't tall.");
            } else if (!isMale && isTall) {
                Console.WriteLine("You're a tall female!");
            } else
            {
                Console.WriteLine("You aren't tall or male.");
            }
        }
    }
}
