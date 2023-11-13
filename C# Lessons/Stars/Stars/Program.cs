/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code will print a triangle out of stars, based on a user integer.
*/
namespace stars
{

    public class above
    {

        public static void Main()
        {
            int column, row, num; // Creates three integers, column, row, and num. column and row are needed to print stars onto different rows/columns.
            Console.WriteLine("Enter an integer, and I will create a star triangle based off of it.");
            num = Convert.ToInt32(Console.ReadLine()); // Obtains a number from the user and stores it in num.

            for (row = 0; row <= num; row++) // This for loop puts the assigns 0 to row, if row is less than or equal to number, it will run a second for loop and prints a space. It also adds one to row variable.
            {
                for (column = 0; column <= row; column++) // This for loop assigns 0 to the column variable, if the row variable is less than or equal to row, it will print a star. At the end the loop adds one to the column. This will loop until it's equal to row, then continue.
                {
                    Console.Write("* "); // Prints a star. If I used WriteLine instead of write it would be in a straight line.
                }
                Console.WriteLine(); // WriteLine is needed to move to a new column/line of stars. This only triggers after the previous for loop has concluded.
            }
            Console.ReadKey();
        }
    }
}