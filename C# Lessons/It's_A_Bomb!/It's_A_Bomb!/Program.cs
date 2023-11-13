/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code asks the user for a setence and detects if the word "Bomb" is contained within it.
*/
namespace Its
{

    public class ABomb
    {

        public static void Main()
        {
            Console.WriteLine("We are on high bomb watch these days, type a setence and I'll check for any bombs.");
            string sentence = Console.ReadLine();

            sentence = sentence.ToLower(); // This sets the sentence to lowercase so that it's case-insensitive.

            if (sentence.Contains("bomb") == true) // Checks the string for the word "bomb"
            {
                Console.WriteLine("There's a bomb! Take cover!");
            }
            else
            {
                Console.WriteLine("Phew, no bombs today, you are safe!");
            }

            Console.ReadKey();
        }

    }

}
