/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code handles functions, mandatory and optional parameters.
*/
namespace Functions
{

    public class Time
    {
        // Void means empty return.
        // A void function doesn't return anything.
        static void customMessage(String word)
        {
            Console.WriteLine("*****" + word + "*****");
        }
        // This function will take two numbers and return their sum.
        static Double twosum(Double num1, Double num2)
        {
            return num1 + num2;
        }
        // This function will take two numbers and return their product.
        static Double twoproduct(Double num1, Double num2)
        {
            return num1 * num2;
        }

        static String toLowerOrUpper(String word, bool toLower) 
        {
            if (toLower) { return word.ToLower(); }
            else { return word.ToUpper(); }
        }
        public static void Main()
        {
            Console.WriteLine("Enter a word.");
            String input = Console.ReadLine();

            // We call functions by their names and add () to it.
            // If the function takes input, we put the input in between the ().
            customMessage(input);
            customMessage(input);
            // The function executes all of the code inside of the function every time we call it.

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Write a number.");
            Double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write another number.");
            Double num2 = Convert.ToDouble(Console.ReadLine());

            // When a function only returns a value, we can store that value in a variable to use it.
            Double sumsult = twosum(num1, num2);
            Double prosult = twoproduct(num1, num2);

            Console.WriteLine("The sum of your two numbers is " + sumsult);
            Console.WriteLine("The product of your two numbers is " + prosult);
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///
            Console.WriteLine("Enter a word.");
            input = Console.ReadLine();
            String changedWord = toLowerOrUpper(input, false);
            Console.WriteLine(changedWord);

            Console.ReadKey();
        }

    }

}