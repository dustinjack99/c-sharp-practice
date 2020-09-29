using System;
using System.Collections.Generic;
using System.Text;

//Remember breakpoints - they're super super powerful

namespace Util
{
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        static public int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                //This is how you throw where exactly the error happened - super useful
                throw new FormatException("Input was not a number.");
            }
            
        }
    }
}
