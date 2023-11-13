/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code deals with switch statements which are conditional statements.
*/
namespace Switch_Statements
{

    public class Switches
    {

        public static void Main()
        {
            /* Console.WriteLine("Enter a number from 1 to 12");
             int month = Convert.ToInt32 (Console.ReadLine());

             /*
             if (month == 1) { Console.WriteLine("Your number corresponds to the month January."); }
             else if (month == 2) { Console.WriteLine("Your number corresponds to the month February."); }
             else if (month == 3) { Console.WriteLine("Your number corresponds to the month March."); }
             else if (month == 4) { Console.WriteLine("Your number corresponds to the month April."); }
             else if (month == 5) { Console.WriteLine("Your number corresponds to the month May."); }
             else if (month == 6) { Console.WriteLine("Your number corresponds to the month June."); }
             else if (month == 7) { Console.WriteLine("Your number corresponds to the month July."); }
             else if (month == 8) { Console.WriteLine("Your number corresponds to the month August."); }
             else if (month == 9) { Console.WriteLine("Your number corresponds to the month September."); }
             else if (month == 10) { Console.WriteLine("Your number corresponds to the month October (The best month)."); }
             else if (month == 11) { Console.WriteLine("Your number corresponds to the month November."); }
             else if (month == 12) { Console.WriteLine("Your number corresponds to the month December."); }
             else  { Console.WriteLine("You really thought you were smart, didn't you?"); } */


            // Switch helps us compare one variable/value to multiple other cases.
            // In this example, the month variable is compared to the numbers in the statement.
            /* switch (month) 
             {
                 case 1: // This Compares the month variable to 1, if the variable is equal to it print the statement.
                     Console.WriteLine("Your month is January.");
                     ; break; // Break command is needed to break out of the switch.
                 case 2:
                     Console.WriteLine("Your month is February.");
                     ; break;
                 case 3:
                     Console.WriteLine("Your month is March.");
                     ; break;
                 case 4:
                     Console.WriteLine("Your month is April.");
                     ; break;
                 case 5:
                     Console.WriteLine("Your month is May.");
                     ; break;
                 case 6:
                     Console.WriteLine("Your month is June.");
                     ; break;
                 case 7:
                     Console.WriteLine("Your month is July.");
                     ; break;
                 case 8:
                     Console.WriteLine("Your month is August.");
                     ; break;
                 case 9:
                     Console.WriteLine("Your month is September.");
                     ; break;
                 case 10:
                     Console.WriteLine("Your month is October. (The best month)");
                     ; break;
                 case 11:
                     Console.WriteLine("Your month is November.");
                     ; break;
                 case 12:
                     Console.WriteLine("Your month is December.");
                     ; break;

                 default: // The default case is only executed if all other cases above it are false.
                     Console.WriteLine("You really thought you were smart, didn't you?");
                      break;
             }*/

            Console.WriteLine("Enter your name to find out your grade.");
            string name = Console.ReadLine();

            switch (name.ToLower()) 
            {
                case "greg":
                    Console.WriteLine("You got 85%");
                    break;
                case "magnus":
                    Console.WriteLine("You got 88%");
                    break;
                case "mann":
                    Console.WriteLine("You got 89%");
                    break;
                case "lochlan":
                    Console.WriteLine("You got 90%");
                    break;
                default:
                    Console.WriteLine("I do not know who you are.");
                    break;
            }

            Console.ReadKey();
        }

    }

}