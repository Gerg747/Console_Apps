using System.Runtime.CompilerServices;

namespace Instructions
{

    public class documentation
    {

        public static void Main()
        {
            Console.WriteLine("Amogus");

            int age = Convert.ToInt32(Console.ReadLine());
            double score = Convert.ToDouble(Console.ReadLine());

            bool keepRunning = false;
            // or
            bool stopTheLoop = true;

            string name = Console.ReadLine();

            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();

            string[] people = { name1, name2, name3 };
            Console.WriteLine(people[0]); // prints the first name.
            Console.WriteLine(people[1]); // prints the second name.
            Console.WriteLine(people[2]); // prints the third name.

            if (4 < 5) { Console.WriteLine("This message only exists because 4 is less than 5"); }

            bool trueOrFalse = true;
            if (trueOrFalse) { Console.WriteLine("This prints this message if the boolean variable was true."); }
            else { Console.WriteLine("This message can only be printed if the boolean variable was false."); }

            int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade) 
            {
                case 9:
                    Console.WriteLine("You are grade 9.");
                    break;
                case 10:                  
                    Console.WriteLine("You are grade 10.");
                    break;
                case 11:
                    Console.WriteLine("You are grade 11.");
                    break;
                case 12:
                    Console.WriteLine("You are grade 12.");
                    break;
                default:
                    Console.WriteLine("You are grade nothing lmao.");
                    break;
            }
            /*
            int counter = 1;

        beginning:

            Console.WriteLine("This is the " + counter + " time to print this message");
            if (counter <= 9) { counter++; goto beginning; }

            for(int i =1; i <= 10; i++) { Console.WriteLine("This is the "+i+" time to print this message."); } 

            int counter2 = 1;
            while (counter2 <= 10) { Console.WriteLine("this is the "+counter2+" time to print this message"); counter2++; }

            int counter3 = 1;
            bool keeprunning = true;
            while (keeprunning) { Console.WriteLine("this is the " + counter3 + " time to print this message"); counter3++;  if (counter3 > 10) { keeprunning = false; }} */

            int counter = 1;
            do { Console.WriteLine(counter); counter++; } while (counter <= 10);

            string[] nameS = { "Greg", "Mann", "Zadius" };
            int[] ageS = { 14, 14, 15 };

            foreach (string wwwwwwww in nameS) 
            { 
                Console.WriteLine(wwwwwwww);
            }
            foreach (int ages in ageS) 
            {
                Console.WriteLine(ages);
            }

            Console.ReadKey();
        }

    }

}
