namespace BradProjectOne.PresentationLayer;
using BradProjectOne.ControllersLayer;

public class UserMenu
{
    public static void ReturningUserMenu()
    {
        int returnMenuChoice = 0;  // collecting choice inputs
        bool validChoice = true; // validating choice inputs to continue or break in switch statement

        Console.WriteLine("\nPlease select an option:"); //HOW CAN I ADD NAME HERE?
        Console.WriteLine("\n1 Enter new blood pressure reading");
        Console.WriteLine("2 View all previous readings");
        Console.WriteLine("3 Delete a previous entry");
        Console.WriteLine("4 Exit");

        do //overall do while loop to collect all user inputs needed
        {
            try
            {
                returnMenuChoice = Convert.ToInt32(Console.ReadLine());

                switch (returnMenuChoice)
                {
                    case 1:

                        int systolic;
                        string systolicInput;
                        int diastolic;
                        string diastolicInput;
                        int pulse;
                        string pulseInput;
                        DateTime date;
                        string dateInput;

                        do //nested do while loops to validate user inputs until validChoice is true at each collection point
                        {
                            Console.WriteLine("\nEnter your systolic pressure:");
                            systolicInput = Console.ReadLine();
                            if (!int.TryParse(systolicInput, out systolic) || systolic < 0 || systolic > 300)
                            {
                                Console.WriteLine("\nSystolic pressure must be a number between 0 and 300. Please try again.");
                            }
                            else
                            {
                                break;
                            }
                        } while (true);

                        do //nested do while loops to validate user inputs until validChoice is true at each collection point
                        {
                            Console.WriteLine("\nThanks! Now enter your diastolic pressure:");
                            diastolicInput = Console.ReadLine();
                            if (!int.TryParse(diastolicInput, out diastolic) || diastolic < 0 || diastolic > 200)
                            {
                                Console.WriteLine("\nDiastolic pressure must be a number between 0 and 200. Please try again.");
                            }
                            else
                            {
                                break;
                            }
                        } while (true);

                        do //nested do while loops to validate user inputs until validChoice is true at each collection point
                        {
                            Console.WriteLine("\nAnd please enter your pulse:");
                            pulseInput = Console.ReadLine();
                            if (!int.TryParse(pulseInput, out pulse) || pulse < 0 || pulse > 300)
                            {
                                Console.WriteLine("\nPulse must be a number between 0 and 300. Please try again.");
                            }
                            else
                            {
                                break;
                            }
                        } while (true);

                        do //nested do while loops to validate user inputs until validChoice is true at each collection point
                        {
                            Console.WriteLine("\nFinally, enter the date of the reading using one of the following formats - MM DD YYYY or MM-DD-YYYY:");
                            dateInput = Console.ReadLine();
                            if (!DateTime.TryParse(dateInput, out date) || date > DateTime.Now)
                            {
                                Console.WriteLine("\nDate must be one of the following formats - MM DD YYYY or MM-DD-YYYY, and cannot be in the future. Please try again.");
                            }
                            else
                            {
                                break;
                            }
                        } while (true);

                        validChoice = true;
                        break;

                    case 2:
                        Console.WriteLine("DISPLAY ALL PREVIOUS READINGS HERE"); // Placeholder
                        validChoice = true;  //Would like to return to the main menu or exit at this point option.
                        break;

                    case 3:
                        Console.WriteLine("DELETE A PREVIOUS ENTRY HERE"); // consider confirming delete? Also return to main menu or exit option.
                        validChoice = true;
                        break;

                    case 4:
                        Console.WriteLine("\nThanks for visiting. Exiting the program.");
                        validChoice = true;
                        Environment.Exit(0); //exits the program
                        return;

                    default:
                        Console.WriteLine("\nPlease enter a valid number.");
                        validChoice = false;
                        break;
                }
            }
            catch (Exception message)
            {
                validChoice = false;
                Console.WriteLine(message);  // might not need to display the message to end user, but it's helpful for debugging, will remove later.
                Console.WriteLine("\n Please enter a valid number.");
            }

        } while (!validChoice);

    }

    public static void UserCreationMenu() //method to create a new user
    {
        bool validChoice = true; // validating choice input to continue or break in switch statement
        string userInput = ""; // collecting user name input
        do
        {

            Console.Clear();
            Console.WriteLine("\nWelcome! Please enter a User Name:");
            userInput = Console.ReadLine().Trim(); //collecting user name input

            if (String.IsNullOrEmpty(userInput)) //if user name is null or empty, it will return false
            {
                Console.WriteLine("User name cannot be blank. Please try again.");
                validChoice = false;
            }
            else if (UserProfileController.UserExists(userInput)) //passing user name to user exists method in controller
            {
                Console.WriteLine("User name already exists. Please try again.");
                validChoice = false;
            }
            else //if user name is not null or empty and does not exist, it will create a new user
            {
                UserProfileController.CreateUser(userInput); //passing user name to create user method in controller
                Console.Clear();
                Console.WriteLine($"Your account with User Name {userInput} has been successfully created!");
                validChoice = true;

                ReturningUserMenu(); //calling user creation menu method

            }



        } while (!validChoice);


    }
}