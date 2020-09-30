using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        }

        public override string ToString()
        {
            return "There are " + GroceryList.Length + " and they are: " + GroceryList.ToString();
        }
    }
}
