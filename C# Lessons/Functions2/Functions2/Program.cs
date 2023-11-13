/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code deals with optional parameters. (input)
*/
namespace Functions2
{

    public class time
    {
        // When writing the function, if the variable does not have an initial value like string word, it is mandatory for the function to work.
        // If the variable has an initial value, like bool showstars = false, then it is simply optional.
        static void customMessage(String word, bool showstars=false)
        {
            // With optional input, if the user sends an input, the variable will use the user's input.
            // However, if the user doesn't send anything, the variable will use the inital (default) value.
            if (showstars)
            {
                Console.WriteLine("****" + word + "****");
            }
            else { Console.WriteLine(word); }
        }
        static void burgerOrder(String burger, bool extraCheese = false) 
        {
            if (extraCheese)
            {
                Console.WriteLine("Your order is as follows: A " + burger + " burger with extra cheese.");
            }
            else { Console.WriteLine("Your order is as follows: A " + burger + " burger without extra cheese."); }
        }

        public static void Main()
        {
            Console.WriteLine("Enter a word.");
            String input = Console.ReadLine();
            customMessage(input);
            customMessage(input, showstars:true);

//--------------------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("It's burger time, what would you want for a burger? (enter your burger name)");
            String bChoice = Console.ReadLine();

            Console.WriteLine("Alrighty, "+bChoice+" it is, now, would you like extra cheese with your order? (y/n)");
            string chess = Console.ReadLine();
            if (chess == "y")
            {
                burgerOrder(bChoice, extraCheese: true);
            }
            else { burgerOrder(bChoice); }
            
            Console.ReadKey();
        }

    }

}