/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code asks the user for a number, then determines whether or not it is even.
*/
namespace Even
{

    public class Odd
    {

        public static void Main()
        {
            Console.WriteLine("Please enter a number and I will determine whether it is even or odd.");
            int number = Convert.ToInt32 (Console.ReadLine());

            if (number % 2 == 0) { Console.WriteLine("Your number is even."); } //The modulus operator deducts whether or not a number's remainder equals zero. If it does, it has to be even.
            else { Console.WriteLine("Your number is odd."); }

            Console.ReadKey();
        }

    }

}
