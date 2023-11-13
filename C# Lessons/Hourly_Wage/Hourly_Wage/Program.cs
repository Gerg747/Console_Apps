/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: This code asks the user for two numbers, then determines their hourly wage/overtime etc.
*/
namespace hourly
{

    public class wage
    {

        public static void Main()
        {
            Console.WriteLine("Hello there! I'm curious, how many hours have you worked yesterday?");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("If you don't mind me asking, how much is your hourly pay?");
            double wage = Convert.ToDouble(Console.ReadLine());

            if (time <= 40)
            {
                double regpay = time * wage;
                Console.WriteLine("You made " + regpay + "$ In regular hours.");
                Console.WriteLine("You made 0$ in overtime hours.");
                Console.WriteLine("The total money made is " + regpay + "$.");
            }
            else if (time > 40)
            {
                double overhours = time - 40;
                double overpay = overhours * wage * 1.5;
                double normalpay = 40 * wage;
                double totalpay = overpay + normalpay;

                Console.WriteLine("You made " + normalpay + "$ In regular hours.");
                Console.WriteLine("You made " + overpay + "$ in overtime hours.");
                Console.WriteLine("The total money made is " + totalpay + "$.");

            }

            Console.ReadKey();
        }

    }

}
