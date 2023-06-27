using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            var myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var Evens = new List<int>();
            var Odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    Evens.Add(myArray[i]);
                }
                else
                {
                    Odds.Add(myArray[i]);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.Write("Even Numbers: ");
            for (int i = 0; i < Evens.Count-1; i++)
            {
                Console.Write($"{Evens[i]}, ");
            }
            Console.Write($"{Evens[Evens.Count-1]}\n");

            Console.Write("\nOdd Numbers: ");
            for (int i = 0; i < Odds.Count-1; i++)
            {
                Console.Write($"{Odds[i]}, ");
            }
            Console.Write($"{Odds[Odds.Count-1]}\n");
        }
    }
}
