/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code randomly generates a number, then asks the user to guess the number. The program will loop until the user is correct.
*/
namespace guessing
{

    public class game
    {

        public static void Main()
        {
            Random random = new Random(); // Creates a new random number.
            int number = random.Next(1, 10); //  the number to an integer.
            bool run = true;

            Console.WriteLine("Guess a number that is between one and ten.");

            while (run) 
            {
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess != number) // != means not equal to.
                {
                    Console.WriteLine("That is incorrect, try again.");
                    run = true;
                }
                else { Console.WriteLine("Congrats! You got it right!"); run = false; }
            }


            Console.ReadKey();
        }

    }

}
