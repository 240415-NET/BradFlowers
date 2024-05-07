namespace BradProjectOne.PresentationLayer
{
    public class MainMenu
    {
        public static void startMenu()
        {
            int mainMenuChoice = 0; // collecting choice input
            bool validChoice = true; // validating choice input to continue or break in switch statement

            Console.Clear();
            Console.WriteLine("Welcome to the Blood Pressure Tracker!");
            Console.WriteLine("Please select an option by entering number:");
            Console.WriteLine("1 New user?");
            Console.WriteLine("2 Returning user?");
            Console.WriteLine("3 Exit");

            do // do while loop to validate user input until validChoice is true
            {
                try
                {
                    mainMenuChoice = Convert.ToInt32(Console.ReadLine());  //read lines are strings, so we need to convert to int

                    switch (mainMenuChoice)
                    {
                        case 1:
                            Console.WriteLine("New user selected");
                            validChoice = true;

                            break;
                        case 2:
                            Console.WriteLine("Welcome back user!");
                            validChoice = true;

                            break;
                        case 3:
                            Console.WriteLine("Exiting program");
                            validChoice = true;
                            return;
                        default:
                            Console.WriteLine("Please enter a valid number.");
                            validChoice = false; //since default is false we can use this to create exception-try / catch
                            break;
                    }
                }
                catch (Exception ex)
                {
                    validChoice = false;
                    Console.WriteLine(ex);  // might not need to display the message to end user, but it's helpful for debugging, will remove later.
                    Console.WriteLine("\n Please enter a valid number."); // \n just creates a line, so in this case between exceptions and this line.
                }

            } while (!validChoice);



        }




    }
}