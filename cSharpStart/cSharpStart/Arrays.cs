﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassArrayMethod
    {
        public void ArrayMethodLesson()
        {
           

         TwoDee();
        
        }

        private void TwoDee()
        {
            // Declare 2D Array
            int[,] numGrid = {
                {1, 2 },
                {3, 4 },
                {5, 6 }

            };

            // 2D Array with 2 rows and 3 columns
            int[,] myArray = new int[2, 3];


            Console.WriteLine(numGrid[0, 0]);
        }

        private void ArrayUpdate()
        {
            // Declaring / Updating Arrays
            int[] luckyNumbers = { 4, 5, 14, 52, 33, 3 };
            string[] friends = new string[5];

            friends[0] = "Ben";
            friends[1] = "Patrick";
            friends[2] = "Amber";
            friends[3] = "Tim";
            friends[4] = "Peter";

            luckyNumbers[2] = 41;

            Console.WriteLine(luckyNumbers[3]);

            // Methods
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
        }
        private void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are:  " + age);
        }

        private int Cube(int num)
        {
            return num * num * num;
            
        }
    }
}
