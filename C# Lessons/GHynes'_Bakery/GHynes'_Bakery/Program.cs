/*
Name: Gregory Hynes.
Class: Comp Sci 20s.
Description: Welcome to my bakery, you can place an order here! 
*/
namespace Greg
{

    public class donut_shop
    {

        public static void Main()
        {
            bool extraOrder = false;
            do
            {
                string donutSize, donutIcing, donutTopping, donutBread, donutamount, tip;

                int choice1;

                Console.WriteLine("Hello there! Welcome to my donut shop! If you would like to place an order, here is my menu.");
                Console.WriteLine("***********************************" +
                    "\n \n Small Donut   $1.56/per donut." +
                    "\n Medium Donut  $1.97/per donut." +
                    "\n Large Donut   $2.45/per donut." +
                    "\n MEGA Donut    $4.99/per donut." +
                    "\n \n--------------ICING----------------" +
                    "\n\n Chocolate Icing    free with order" +
                    "\n Vanilla Icing      free with order" +
                    "\n Strawberry Icing   free with order" +
                    "\n Blueberry Icing    free with order" +
                    "\n \n------------TOPPINGS---------------" +
                    "\n\n Flavored Sprinkles    $0.20" +
                    "\n Chocolate Drizzle     $0.25" +
                    "\n Various Berries       $0.30" +
                    "\n Bullet Casings        $0.10" +
                    "\n No Toppings           free" +
                    "\n \n-------------BREAD----------------" +
                    "\n\n Jelly-filled" +
                    "\n Whole Wheat" +
                    "\n Amogus" +
                    "\n Chocolate Drizzle" +
                    "\n \n***********************************");

                Console.WriteLine("We serve multiple donuts at a selectable size. What sized donuts would you like to order?");
                Console.WriteLine("Select 1 for Small Donuts, 2 for Medium Donuts, 3 for Large Donuts, and 4 for MEGA Donuts.");
                choice1 = Convert.ToInt32 (Console.ReadLine());
 
                switch (choice1) 
                {
                    case 1:
                        donutSize = ("Small");
                        Console.WriteLine("Alright, small it is.");
                            break;
                    case 2:
                        donutSize = ("Medium");
                        Console.WriteLine("Nice choice.");
                        break;
                    case 3:
                        donutSize = ("Large");
                        Console.WriteLine("Ok... Large donuts.");
                        break;
                    case 4:
                        donutSize = ("MEGA");
                        Console.WriteLine("I haven't had anyone order "+donutSize+" donuts in such a long time...");
                        break;
                    default:
                        Console.WriteLine("...wtf");
                            break;
                }
                Console.WriteLine("Alrighty now moving onto the icing, what flavor would you like? 1 for chocolate, 2 for vanilla, 3 for Strawberry, and 4 for blueberry.");
                

            } while (extraOrder == true);


            Console.ReadKey();
        }

    }

}
