using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public static string cover = "Hard";

        //Constructor
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        //You are allowed to have multiple constructors / empty constructors
        public Book ()
        {

        }

                
    }
}
