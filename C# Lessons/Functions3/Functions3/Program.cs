/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: Summary of the functions lessons.
*/
using System.Diagnostics.CodeAnalysis;

namespace Functions
{

    public class three
    {
        // To declare a function, you write static data_type function_name (input_data_type variable name)
        static int twosum(int num1, int num2) 
        { 
            return num1 + num2;
        }

        static String burgerOrder(String order, bool extraCheese = false) 
        {
            if (extraCheese) { return order + "with extra cheese."; }
            else { return order + "without extra cheese."; }
        }
        public static void Main()
        {

            Console.ReadKey();
        }

    }

}
