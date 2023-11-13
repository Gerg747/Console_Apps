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

                double TotaldonutCost, Totalsemicost, FinalCost, SemiFinalCost;

                string donutSize, donutIcing, donutTopping, donutDough, Address, receipt, again;

                double donutSizecost, donutToppingcost, donutDoughcost, tip, tipcalc, taxes;

                int choice1, choice2, choice3, choice4, choice5, donutAmount;

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
                    "\n \n-------------DOUGH----------------" +
                    "\n\n Jelly-filled         $0.50" +
                    "\n Cinnamon-Flavored    $0.25" +
                    "\n Whole Wheat          free" +
                    "\n Standard             free" +
                    "\n \n***********************************");

                Console.WriteLine("We serve multiple donuts at a selectable size. What sized donuts would you like to order?");
                Console.WriteLine("Select 1 for Small Donuts, 2 for Medium Donuts, 3 for Large Donuts, and 4 for MEGA Donuts.");
            
            begin:
                choice1 = Convert.ToInt32 (Console.ReadLine());
 
                switch (choice1) 
                {
                    case 1:
                        donutSize = ("Small");
                        Console.WriteLine("Alright, small it is.");
                        donutSizecost = 1.56;
                            break;
                    case 2:
                        donutSize = ("Medium");
                        Console.WriteLine("Nice choice.");
                        donutSizecost = 1.97;
                        break;
                    case 3:
                        donutSize = ("Large");
                        Console.WriteLine("Ok... Large donuts.");
                        donutSizecost = 2.45;
                        break;
                    case 4:
                        donutSize = ("MEGA");
                        Console.WriteLine("I haven't had anyone order "+donutSize+" donuts in such a long time...");
                        donutSizecost = 4.99;
                        break;
                    default:
                        Console.WriteLine("...wtf");
                        goto begin;
                }

                Console.WriteLine("Alrighty now moving onto the icing, what flavor would you like? 1 for chocolate, 2 for vanilla, 3 for Strawberry, and 4 for blueberry.");

            start:
                choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2) 
                {
                    case 1:
                        donutIcing = ("Chocolate         ");
                        Console.WriteLine("Chocolate's my favorite, too.");
                        break;
                    case 2:
                        donutIcing = ("Vanilla           ");
                        Console.WriteLine("Sometimes you gotta just go with vanilla.");
                        break;
                    case 3:
                        donutIcing = ("Strawberry        ");
                        Console.WriteLine("Strawberry icing it is, then.");
                        break;
                    case 4:
                        donutIcing = ("Blueberry         ");
                        Console.WriteLine("I hate blueberries");
                        break;
                    default:
                        Console.WriteLine("why are you doing this to me...");
                        goto start;
                }

                Console.WriteLine("Ok, now it's time for the toppings. Choose 1 for Flavored Sprinkles, 2 for Chocolate Drizzle, 3 for Various Berries, 4 for Bullet Casings, and 5 for none.");

            beginning:
                choice3 = Convert.ToInt32(Console.ReadLine());
                switch (choice3) 
                { 
                    case 1:
                        donutTopping = ("Flavored Sprinkles");
                        Console.WriteLine("Natural choice.");
                        donutToppingcost = 0.20;
                        break;
                    case 2:
                        donutTopping = ("Chocolate Drizzle ");
                        Console.WriteLine("Okay.");
                        donutToppingcost = 0.25;
                        break;
                    case 3:
                        donutTopping = ("Various Berries   ");
                        Console.WriteLine("Nothing wrong with some berries.");
                        donutToppingcost = 0.30;
                        break;
                    case 4:
                        donutTopping = ("Bullet Casings    ");
                        Console.WriteLine("Delicious.");
                        donutToppingcost = 0.10;
                        break;
                    case 5:
                        donutTopping = ("None              ");
                        Console.WriteLine("Feeling plain today, I see.");
                        donutToppingcost = 0;
                        break;
                    default:
                        Console.WriteLine("I don't paid enough for this...");
                        goto beginning;
                }
                Console.WriteLine("Next up is the dough. Select 1 for Jelly-Filled, select 2 for Cinnamon-Flavored, select 3 for Whole Wheat, and finally, select 4 for Standard dough.");

            theExposition:
                choice4 = Convert.ToInt32(Console.ReadLine());
                switch (choice4)
                {
                    case 1:
                        donutDough = ("Jelly-Filled      ");
                        Console.WriteLine("Alright.");
                        donutDoughcost = 0.50;
                        break;
                    case 2:
                        donutDough = ("Cinnamon-Flavored ");
                        Console.WriteLine("I love Cinnamon.");
                        donutDoughcost = 0.25;
                        break;
                    case 3:
                        donutDough = ("Whole Wheat       ");
                        Console.WriteLine("Trying to be healthy at a donut shop, are you?");
                        donutDoughcost = 0;
                        break;
                    case 4:
                        donutDough = ("Standard          ");
                        Console.WriteLine("Ok.");
                        donutDoughcost = 0;
                        break;
                    default:
                        Console.WriteLine("Give me a break...");
                        goto theExposition;
                }
                Console.WriteLine("Now that you've customized your donut, how many of them do you want?");
                donutAmount = Convert.ToInt32(Console.ReadLine());

                if (donutAmount > 30) { Console.WriteLine("Holy crap, what are you doing with all of those donuts?!"); }

                Console.WriteLine("Okay, enter your address so we can send your donuts to you.");
                Address = Console.ReadLine();

                Console.WriteLine("In the final step of the ordering process, would you like to tip? Choose 1 for 5%, 2 for 10%, 3 for 20%, 4 for 50%, and 5 for none");

            doitagain:
                choice5 = Convert.ToInt32(Console.ReadLine());
                switch (choice5)
                {
                    case 1:
                        tip = 0.05;
                        Console.WriteLine("Thanks!");
                        break;
                    case 2:
                        tip = 0.10;
                        Console.WriteLine("Your generosity is amazing.");
                        break;
                    case 3:
                        tip = 0.20;
                        Console.WriteLine("Thank you so much!");
                        break;
                    case 4:
                        tip = 0.50;
                        Console.WriteLine("Are you MrBeast or something?");
                        break;
                    case 5:
                        tip = 0;
                        Console.WriteLine("No tip? Alright.");
                        break;
                    default:
                        Console.WriteLine("...You really think this is funny, don't you?");
                        goto doitagain;
                }
                Console.WriteLine("And that's it! Would you like a reciept? (y/n)");
                receipt = Console.ReadLine();

                TotaldonutCost = donutSizecost * donutAmount;
                Totalsemicost = TotaldonutCost + donutToppingcost + donutDoughcost;
                taxes = Totalsemicost * 0.12;
                tipcalc = Totalsemicost * tip;
                FinalCost = Totalsemicost + tipcalc + taxes;
                SemiFinalCost = Totalsemicost + tipcalc;

                if (receipt == "y") 
                {
                    Console.WriteLine("***********************************************" +
                    "\n -------THANK YOU FOR ORDERING AT GREG'S-------"  +
                    "\n " + donutAmount + " " + donutSize + " donut(s).         $" + TotaldonutCost + "" +
                    "\n "+donutIcing+"         $0.00" +
                    "\n "+donutTopping+"         $" +donutToppingcost+ " " +
                    "\n "+donutDough+"         $"+donutDoughcost+ "" +
                    "\n Tip:                       "+tip+ "%" +
                    "\n Cost:                      $"+SemiFinalCost+ "" +
                    "\n Tax:                       $"+taxes+"" +
                    "\n Total:                     $" +FinalCost+ ""+
                    "\n Address:                   " + Address + "" +
                    "\n \n***********************************************");

                    string Receipt = "***********************************************" +
                    "\n -------THANK YOU FOR ORDERING AT GREG'S-------" +
                    "\n " + donutAmount + " " + donutSize + " donut(s).         $" + TotaldonutCost + "" +
                    "\n " + donutIcing + "         $0.00" +
                    "\n " + donutTopping + "         $" + donutToppingcost + " " +
                    "\n " + donutDough + "         $" + donutDoughcost + "" +
                    "\n Tip:                       " + tip + "%" +
                    "\n Cost:                      $" + SemiFinalCost + "" +
                    "\n Tax:                       $" + taxes + "" +
                    "\n Total:                     $" + FinalCost + "" +
                    "\n Address:                   " + Address + "" +
                    "\n \n***********************************************";
                    string location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    TextWriter text = new StreamWriter(location + "\\Receipt.txt");
                    text.Write(Receipt); 
                    text.Flush();
                }

                Console.WriteLine("Do you want to place another order? (y/n)");
                again = Console.ReadLine();
                if (again == "y") { extraOrder = true; }
                else { extraOrder = false; }

            } while (extraOrder == true);

            Console.ReadKey();
        }

    }

}