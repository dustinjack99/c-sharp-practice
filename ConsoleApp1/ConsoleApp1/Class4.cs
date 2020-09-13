using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassIfLesson
    {
        public void IfLesson()
        {
            While();
        }

        private void While()
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine(GetDay(4));
        }

        private string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                default:
                    dayName = "Invalid Day Nymber";
                    break;
            }
            return dayName;

        }
        private void isMale()
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are tall and male!");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You're male, but you ain't tall.");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You're a tall female!");
            }
            else
            {
                Console.WriteLine("You aren't tall or male.");
            }
        }
    }
}
