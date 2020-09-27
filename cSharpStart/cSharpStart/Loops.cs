using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ConsoleApp1
{
    public class ClassLoopLessons
    {
        public void LoopLessons()
        {
            ForLoop();
        }

        private void ForLoop()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private void Guess()
        {
            string secretWord = "giraffe";
            string guess = "";
            int guesses = 4;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses) {
                if (guesses > 0)
                {
                    guesses--;
                    Console.WriteLine("Guesses Left: " + guesses);
                    Console.WriteLine("Enter guess:");
                    guess = Console.ReadLine();
                    if (guess == secretWord)
                    {
                        Console.WriteLine("That's it!! The scret word was: " + secretWord);
                        guess = secretWord;
                    } else
                    {

                    Console.Write("Nope! That wasn't the word!");
                    }
                } else 
                {
                    outOfGuesses = true;
                    Console.Write("Oh no! You're out of guesses! Better luck next time.");
                }
                
            }

            Console.Write("You did it!! The word was: " + secretWord);
        }

        private void While()
        {
            int index = 1;

            // Huh, didn't know a do/while loop was a thing
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index <= 5);
            
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
