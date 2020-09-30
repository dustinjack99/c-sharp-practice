using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    class Loops
    {
        public string BreakAndContinue()
        {
            var sb = new StringBuilder();

            var words = new List<string> { "Bread", "Milk", "Eggs", "Cheese", "Apples" };

            foreach (var word in words)
            {
                //continue skips single iteration of loop
                if (word.StartsWith("M")) continue;


                //break ends the loop entirely
                if (word.StartsWith("C")) break;

                sb.AppendLine(word);
            }

            return sb.ToString();
        }
        public int DoWhileLoop()
        {
            var sum = 0;
            var counter = 0;

            //condition evaluated after do block runs
            //If you need block to run at least once, use do/while
            do
            {
                sum += counter;
                counter++;
            } while (counter < 100);

            return sum;
        }
        public int WhileLoop()
        {
            var sum = 0;
            var counter = 0;

            //evaluates condition first
            while(counter < 100)
            {
                sum += counter;
                counter++;
            }

            return sum;
        }
    }
}
