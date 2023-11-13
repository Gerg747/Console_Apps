/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: Test Stuff!
*/
namespace Test
{

    public class time
    {
        static void CustomMessage(string word, bool capital, bool lower)
        {
            if (capital) 
            {
                string up = word.ToUpper();
                Console.WriteLine("****"+up+"****");
            }
            else if (lower)
            {
                string Low = word.ToLower();
                Console.WriteLine("****" + Low + "****");
            }
            else
            {
                Console.WriteLine("****" + word + "****");
            }
        }
        public static void Main()
        {
            Console.WriteLine("Write a word.");
            string word = Console.ReadLine();

            Console.WriteLine("Alright, do you want to capitalize all the letters(press 1), lowercase them all(press 2), or not change it(press 3).");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) 
            { 
                CustomMessage(word, capital: true, lower: false); 
            }
            else if (choice == 2)
            {
                CustomMessage(word, capital: false, lower: true);
            }
            else
            {
                CustomMessage(word, capital: false, lower: false);
            }

            Console.ReadKey();
        }

    }

}
