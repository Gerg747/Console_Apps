/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code graps two numbers from the user, and then calculates every odd number in between them.
*/
namespace Listing
{

    public class TheOdd
    {

        public static void Main()
        {
            Console.WriteLine("Enter your lower boundry.");
            int lower = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter your upper boundry.");
            int upper = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The odd numbers in-between your numbers, "+lower+" and "+upper+" are...");

            int between = lower + 1;

        beginning: 
            {
                if (between % 2 != 0) // The modulus operator checks to see if, when the integer is divided by 2, the remainder is zero, if it's true, it has to be even.
                { Console.WriteLine(between); } // Prints the number only if the number is odd.

                between++; // Adds one to the counter.
                if (between < upper) { goto beginning; } // If the in between number is still less than the higher number, continue the loop.
            }
            Console.ReadKey();
        }

    }

}