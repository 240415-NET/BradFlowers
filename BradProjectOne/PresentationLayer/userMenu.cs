namespace BradProjectOne.PresentationLayer;

using BradProjectOne.ControllersLayer;
using BradProjectOne.Models;

public class UserMenu
{

    public static void UserLoginVerification()
    {
        bool validChoice = true; // validating choice input to continue or break in switch statement
        string userName = ""; // collecting user name input

        do
        {
            Console.WriteLine("\nWelcome back! Please enter your User Name:");
            userName = Console.ReadLine().Trim(); //collecting user name input


            if (String.IsNullOrEmpty(userName)) //if user name is null or empty, it will return false
            {
                Console.WriteLine("User name cannot be blank. Please try again.");
                validChoice = false;
                //continue; will take you to the while statement(similiar to an else statement)
            }
            else
            {
                UserProfile user = UserProfileController.GetUser(userName);
                if (user == null)
                {
                    Console.WriteLine("User name does not exist. Please try again.");
                    validChoice = false;

                }
                else //if user name is not null or empty and does not exist, it will log in existing user
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome back!");
                    validChoice = true;

                    ReturningUserMenu(user);
                }
            }

        } while (!validChoice);

    }

    public static void ReturningUserMenu(UserProfile user)
    {
        int returnMenuChoice = 0;
        bool validChoice = true; // validating choice inputs to continue or break in switch statement

        Console.WriteLine($"\nPlease select an option, {user.UserName}:");
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
                        UserMenu.NewBpReading(user); // pass the 'user' argument to the method
                        break;

                    case 2:
                        Console.WriteLine("DISPLAY ALL PREVIOUS READINGS HERE"); // Placeholder
                        UserMenu.ViewAllUserBpRecords(user, ReadingId, Systolic, Diastolic, Pulse, Date);
                        validChoice = true;
                        break;

                    case 3:
                        validChoice = true;
                        DeleteBpReading(user);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine($"\nThanks for visiting, {user.UserName}. Exiting the program.");
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
                Console.WriteLine("\n Please enter a valid number.");
            }


        } while (!validChoice);

    }

    public static void NewBpReading(UserProfile user)
    {
        int systolic;
        string systolicInput;
        int diastolic;
        string diastolicInput;
        int pulse;
        string pulseInput;
        DateTime date;
        string dateInput;
        bool validChoice = true;
        Guid readingId = Guid.NewGuid();

        do //nested do while loops to validate user inputs until validChoice is true at each collection point
        {
            Console.Clear();
            Console.WriteLine($"Thank you, {user.UserName}! Let's collect your reading.");
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

        BloodPressureController.CreateBloodPressureRecord(user, readingId, systolic, diastolic, pulse, date); //passing user inputs to create blood pressure record method in controller

        Console.WriteLine($"\nThank you for the entry, {user.UserName}. It has been stored to your account!  If you would like to return to the main menu, please press Enter.  Otherwise type 'exit' to quit.");
        string returnToMenu = Console.ReadLine().ToLower();

        if (returnToMenu == "exit" || returnToMenu == "no" || returnToMenu == "quit")
        {
            Console.WriteLine($"\nThanks for visiting, {user.UserName}. Exiting your Account.");
            Environment.Exit(0); //exits the program
            return;
        }
        else
        {
            Console.WriteLine("Returning to main menu.");
            ReturningUserMenu(user); //returning to main menu if user does not exit program
        }
    }

    public static void UserCreationMenu() //method to create a new user
    {
        bool validChoice = true; // validating choice input t3o continue or break in switch statement
        string userInput = ""; // collecting user name input
        do
        {
            Console.WriteLine("\nWelcome! Please enter a User Name:");
            userInput = Console.ReadLine().Trim(); //collecting user name input
            Console.Clear();

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
                UserProfile user = UserProfileController.CreateUser(userInput); //passing user name to create user method in controller
                Console.Clear();
                Console.WriteLine($"Your account with user name, {userInput}, has been successfully created!");
                validChoice = true;

                ReturningUserMenu(user);
            }



        } while (!validChoice);

    }

    public static void DeleteBpReading(UserProfile user)
    {
        DateTime dateInput;

        Console.Clear();
        Console.WriteLine("Please enter the date of the reading you would like to delete using one of the following formats - MM DD YYYY or MM-DD-YYYY:");
        dateInput = Convert.ToDateTime(Console.ReadLine());

        BloodPressureController.DeleteBloodPressureRecord(user.UserId, dateInput);

        Console.WriteLine("\nYour record has been deleted from your account.  If you would like to return to the main menu, please press Enter.  Otherwise type 'exit' to quit.");
        string returnToMenu = Console.ReadLine().ToLower();

        if (returnToMenu == "exit" || returnToMenu == "no" || returnToMenu == "quit")
        {
            Console.WriteLine($"\nThanks for visiting, {user.UserName}. Exiting your Account.");
            Environment.Exit(0); //exits the program
            return;
        }
        else
        {
            Console.WriteLine("Returning to main menu.");
            ReturningUserMenu(user); //returning to main menu if user does not exit program
        }

    }
    public static void ViewAllUserBpRecords(UserProfile user, BloodPressureRecord ReadingId, BloodPressureRecord Systolic, BloodPressureRecord Diastolic, BloodPressureRecord Pulse, BloodPressureRecord Date)
    {
        BloodPressureController.ViewAllUserBpRecords(user, ReadingId, Systolic, Diastolic, Pulse, Date);
    }

}



