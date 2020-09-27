using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Restrict creating new instances by using 'static'
    static class UsefulTools
    {
        public static void SayHi(string name )
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
