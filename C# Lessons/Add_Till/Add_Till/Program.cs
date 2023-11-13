/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code asks the user for a number, then determines every number, from zero, that it's between. It also adds all of the numbers.
*/
namespace Adding
{

    public class Until
    {

        public static void Main()
        {
            int sum = 0; // Creates a sum integer that will be used in the loop later.

            Console.WriteLine("Enter a number, and I'll count every number until that number."); 
            int num = Convert.ToInt32(Console.ReadLine()); // Gets the upper boundry that the code will count to.

            for (int count = 0; count <= num; count++) // int count = 0 is the initialization, then checks to see if count is less than/equal to the user number, adds one to the count, after it will perform the actions inside if the statement was true.
            {
                sum = sum + count; // Adds count to sum in increments, every time the loop is initiated.

                Console.WriteLine(count); // Displays the current value of the count variable.

            }
            Console.WriteLine("The sum of all of these numbers is " + sum + ".");

            Console.ReadKey();
        }

    }

}