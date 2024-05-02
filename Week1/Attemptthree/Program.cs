namespace Attemptthree;
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
        bool quit = false;
        string additionalitem;
        string additionalitemcheck = "yes";

        do
        {
            Console.WriteLine("What would you like to order, or type quit to exit?");
            foodorder = Console.ReadLine().ToLower();

            if (foodorder == "quit" || foodorder == "q")
            {
                Console.WriteLine("Come again");
                quit = true;
            }
            else if (foodorder != "quit" || foodorder != "q")
            {
                Console.WriteLine("Would you like anything else");
                additionalitemcheck = Console.ReadLine().ToLower();
                
                    if (additionalitemcheck == "yes" || additionalitemcheck == "y")
                    {
                        Console.WriteLine("what else would you like?");
                        additionalitem = Console.ReadLine().ToLower();
                    }
                    else if (additionalitemcheck == "no" || additionalitemcheck == "n")
                    {
                        Console.WriteLine("Thanks for ordering " + foodorder);
                        quit = true;
                    }   
                    else 
                        quit = true;
                    
                    }
            else
            {
                Console.WriteLine($"You have ordered "  + foodorder);
                quit  = true;
            }
            
        } while (quit == false);


    }
    

}