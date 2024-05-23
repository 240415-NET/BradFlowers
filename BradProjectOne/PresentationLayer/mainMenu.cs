namespace BradProjectOne.PresentationLayer;

public class MainMenu
{
    public void StartMenu()
    {
        int mainMenuChoice = 0; // collecting choice input
        bool validChoice = true; // validating choice input to continue or break in switch statement

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("******************************************************");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("********Welcome to the Blood Pressure Tracker!********");
        Console.ResetColor();
        Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("******************************************************");
        Console.ResetColor();
        Console.WriteLine("\nPlease select an option by entering a number:\n");
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
                        try
                        {
                            UserMenu.UserCreationMenu(); //calling user creation menu method
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"An error occurred: {e.Message}");
                        }
                        break;
                    case 2:
                        try
                        {
                            UserMenu.UserLoginVerification();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"An error occurred: {e.Message}");
                        }
                        validChoice = true;
                        break;
                    case 3:
                        Console.WriteLine("\nThanks for visiting. Exiting the Blood Pressure Tracker.");
                        validChoice = true;
                        Environment.Exit(0); //exits the program
                        return;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        validChoice = false; //since default is false we can use this to create exception-try / catch
                        break;
                }
            }
            catch (Exception ex)
            {
                validChoice = false;
                Console.WriteLine("Please enter a valid choice."); // \n just creates a line, so in this case between exceptions and this line.
            }
        } while (!validChoice);
    }
}