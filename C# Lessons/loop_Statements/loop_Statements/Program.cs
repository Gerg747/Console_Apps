/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code deals with loop statements.
*/
namespace looping
{

    public class stuff
    {

        public static void Main()
        {
            /*bool keepRunning = true;
            string decision = "n";
            while (keepRunning) 
            { 
                Console.WriteLine("This loop is running");
                Console.WriteLine("Do you want to stop running? Press y for yes or n for no.");
                decision = Console.ReadLine();

                if (decision == "y") { keepRunning = false; }    
            }*/

            // Do while loops will always work atleast one time.
            // This is because it performs the action within the brackets first, then checks the condition.
            /*
            do
            {
                Console.WriteLine("This loop is running.");
            } while (1 > 2); // Regardless of wether it is true or false, the loop will work once.
            // However, the condition needs to be true in order for it to run more than once.   */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            int count = 1;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count <= 10);
            */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            // Initialization is count=0.
            // Boolean expression is count<10.
            // Update is count++ which adds one to the number.
            // The loop will continue to work as long as the Boolean expression is correct.

            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(count+1);
            }

            // Initialization is count=10.
            // Boolean expression is count<=100.
            // Update is count+=10 which means count = count + 10.
            // The loop will continue to work as long as the Boolean expression is correct.

            for (int count = 10; count <= 100; count += 10)
            {
                Console.WriteLine(count);
            }

            // Counts down from 10 to 1.
            for (int count = 10; count > 0; count--)
            {
                Console.WriteLine(count);
            }

            // This is an infinite loop because the Boolean expression will never be false.
            for (int count = 1; count > 0; count ++)
            {
                Console.WriteLine(count);
            }*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            String[] names = { "Greg", "Mann", "Magnus", "Martin"}; // Array

            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i]);
            }
            // There's a better way to loop with arrays.
            foreach (String name in names) 
            { 
                Console.WriteLine(name);
            }
            int[] numbers = { 10, 20, 30, 100, 54657, 3453, 2345, 432, 43242 ,2342 ,22 };

            foreach (int number in numbers) 
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }

    }

}
