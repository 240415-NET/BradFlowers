using System.Net;

namespace FirstChallengeMethod;

class Program

// 1 - Prompts the user for some input
// 2 - Does something with that input
// 3 - Handles any exceptions that may arise during the running of the application (no hard crashing)
// 4 - Continues to run until the user quits the application, from within the application (no ctrl+c)

/*

My thoughts
-Food ordering system
-do while loop to stop or keep going
-ask for item the user would like or give option to quit--use console.writeline and console.read
-after selecting one item, ask if they would like to add another item or to enter quit/q to end(while with q or quit)
-If they want to add another item, ask for another item and loop
-if they want to quit or enter q, end the loop with with a statement of what they all ordered
-exceptions can be done with try/catch but I need to get the loop figured out first



*/


/*
define your variables
do while loop so user has option to quit - can be done with a boolean in while at the end
use a write to collect input from customer - in do statement
in write statment give a choice to type quit to exit
If else statment to keep asking for items or to quit

*/
{
    static void Main(string[] args)
    {

        string foodorder;
        bool Doneordering = false;
        string Anotheritem;
        List<string> AllFoodOrders = new List<string>();


        Console.WriteLine("What would you like to order, or type quit to exit?");
        foodorder = Console.ReadLine().ToLower();


        do
        {
            // Console.WriteLine("What would you like to order, or type quit to exit?");
            // foodorder = Console.ReadLine().ToLower();

            if (foodorder == "quit" || foodorder == "q")
            {
                Console.WriteLine("Thank you!");
                return;
            }
            bool found = FindOrder(foodorder);
            if (found == false)
            {
                Console.WriteLine("We do not carry this item. Please select something else.");
                foodorder = Console.ReadLine().ToLower();
            }
            else
            {
                AllFoodOrders.Add(foodorder);
                Console.WriteLine($"Thank you for your order of {string.Join(", ", AllFoodOrders)}");
                Console.WriteLine("Would you like to order anything else?");
                Anotheritem = Console.ReadLine().ToLower();
                if (Anotheritem == "yes" || Anotheritem == "y")
                {
                    Console.WriteLine("What else would you like to order?");
                    foodorder = Console.ReadLine().ToLower();
                    //Otheritem = Console.ReadLine().ToLower();
                    //foodorder = $"{foodorder}, {Otheritem}";

                }
                else if (Anotheritem == "no" || Anotheritem == "n")
                {
                    Console.WriteLine($"Thank you for your order of {string.Join(", ", AllFoodOrders)}");
                    Doneordering = true;
                }
                else
                {
                    Console.WriteLine("Please enter Yes or No");

                }

            }
        } while (Doneordering == false);
    }

    static bool FindOrder(string foodorder)
    {
        var fooditems = new List<string> { "pizza", "burger", "fries", "salad", "soda", "water" };
        if (fooditems.Contains(foodorder))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}