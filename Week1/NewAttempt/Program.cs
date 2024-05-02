using System.Net;

namespace NewAttempt;

class Program

// 1 - Prompts the user for some input
// 2 - Does something with that input
// 3 - Handles any exceptions that may arise during the running of the application (no hard crashing)
// 4 - Continues to run until the user quits the application, from within the application (no ctrl+c)

{
    static void Main(string[] args)
    {

        string foodOrder;
        string anotherItem;
        var orderManagement = new OrderManagement(); //create an instance of the OrderManagement class



        while (true) //infinite loop
        {
            Console.WriteLine("What would you like to order, or type quit to exit?");
            foodOrder = Console.ReadLine().ToLower();

            //Add quanity or order and then use try catch to handle exceptions

            if (foodOrder == "quit" || foodOrder == "q")
            {
                Console.WriteLine("Thank you!");
                return;
            }
            bool found = orderManagement.AddOrder(foodOrder);
            if (found == false)
            {
                Console.WriteLine("We do not carry this item. Please select something else.");
            }
            else
            {
                var orders = string.Join(", ", orderManagement.Orders.Select(o => o.Name));
                Console.WriteLine($"Thank you for your order of {orders}");
                Console.WriteLine("Would you like to order anything else?");
                anotherItem = Console.ReadLine().ToLower();

                if (anotherItem == "no" || anotherItem == "n")
                {
                    Console.WriteLine($"Thank you for your order of {orders}");
                    return;

                }
                else if (anotherItem != "yes" && anotherItem != "y")
                {
                    Console.WriteLine("Please enter Yes or No");

                }

            }
        }

    }

    // static bool FindOrder(string foodOrder)
    // {
    //     var fooditems = new List<string> {"pizza", "burger", "fries", "salad", "soda", "water"};
    //     if (fooditems.Contains(foodOrder))
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }
}










