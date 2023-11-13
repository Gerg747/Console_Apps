/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code takes a number from the user and decides wether or not it is bigger than 10.
*/
namespace ConsoleApp
{

    public class Conditional_Statements
    {

        public static void Main()
        {
            /*
            // < means less than.
            // > means greater than.
            // == means equal to.
            // <= means less than or equal to.
            // >= means greater than or equal to.
            // !+ means not equal to.

            Console.WriteLine("Enter a number please.");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 10)
            {
                Console.WriteLine("The number you have chosen is less than 10.");
            }
            else if (num == 10)
            {
                Console.WriteLine("Your number is 10, nice.");
            }
            else
            {
                Console.WriteLine("The number you selected appears to be greater than 10.");
            }
            */

            /*
            Console.WriteLine("Hello there! Please tell me what score you got on your math test.");
            double score = Convert.ToDouble(Console.ReadLine());

            if (score >= 90) { Console.WriteLine("Wow! Nice job! You got an A on your test!"); }
            else if (score >= 80) { Console.WriteLine("It appears you got a B! That's going to make your parents happy."); }
            else if (score >= 70) { Console.WriteLine("Great job on that C! Could be better, but it's great nonetheless!"); }
            else if (score >= 60) { Console.WriteLine("Man, you got a D. You passed, atleast."); }
            else if (score >= 50) { Console.WriteLine("You need to pay more attention in class, you only got an E. That barely passes."); }
            else { Console.WriteLine("Aaannnd you failed, F. Your parents will be sure to make sure you never get one again."); }
            */

            // Boolean variables can only contain true or false conditions.

            /*
            bool isSkyBlue = true;
            bool isFoodReady = true;

            // With the && (and) operator, the statement only executes if all of the conditions are true.
            // True && False = False.
            // False && False = False.
            // False && True = False.
            // True && True = True.

        
            if (isSkyBlue && isFoodReady) { Console.WriteLine("Great!, now we can go for a nice picnic."); }
            else { Console.WriteLine("Aw man, I guess we can't go have a picnic then."); } */
             
            // With the || (Or) operator only one condition needs to be met in order to be executed.
            // False || False = False.
            // False || True = True.
            // True || False = True.
            // True || True = True.

            Console.WriteLine("Enter your grade here in order to see if you are ready for the field trip");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade != 11 && grade != 12) { Console.WriteLine("Well, it seems your grade is too low to go on the field trip."); }

            else { Console.WriteLine("Alrighty then, you can go on the field trip!"); }

            ///////////////////////////////////////////////////////////////////////////////////
            if (grade == 11 || grade == 12) { Console.WriteLine("Alrighty then, you can go on the field trip!"); }

            else { Console.WriteLine("Well, it seems your grade is too low to go on the field trip."); }

            Console.ReadKey();
        }

    }

}