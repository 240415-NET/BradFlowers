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
            Console.WriteLine("\nWelcome back! Please enter your User Name or hit Enter to return to the Main Menu:");
            userName = Console.ReadLine().Trim(); //collecting user name input

            if (String.IsNullOrEmpty(userName)) //if user name is null or empty, it will return false
            {
                MainMenu mainMenu = new MainMenu(); //creating an instance of the main menu because we are returning to the main menu which isn't static
                mainMenu.StartMenu();
                validChoice = true;
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
                    Console.WriteLine($"Thanks for stopping by!");
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

        Console.Clear();
        Console.WriteLine($"\nPlease select an option, {user.UserName}:");
        Console.WriteLine("\n1 Enter new blood pressure reading");
        Console.WriteLine("2 View all previous readings");
        Console.WriteLine("3 Delete a previous entry");
        Console.WriteLine("4 Exit");

        do
        {
            try
            {
                returnMenuChoice = Convert.ToInt32(Console.ReadLine());

                switch (returnMenuChoice)
                {
                    case 1:
                        UserMenu.NewBpReading(user); // pass the 'user' argument to the method
                        validChoice = true;
                        break;

                    case 2:
                        UserMenu.ViewAllUserBpRecords(user.UserId, user); //pass the arguments of user.UserId and user to the method
                        validChoice = true;
                        break;

                    case 3:
                        validChoice = true;
                        DeleteBpReading(user);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine($"\nThanks for visiting, {user.UserName}. Exiting the Blood Pressure Tracker.");
                        validChoice = true;
                        Environment.Exit(0); //exits the program
                        return;

                    default:
                        Console.WriteLine("\nPlease enter a valid choice.");
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
        string initialInput;

        Console.Clear();
        Console.WriteLine($"Are you ready to enter a new record, {user.UserName}? If so hit Enter or type 'back' to go back to the User Menu.");
        initialInput = Console.ReadLine();

        if (initialInput.ToLower() == "back" || initialInput.ToLower() == "return" || initialInput.ToLower() == "exit" || initialInput.ToLower() == "no")
        {
            ReturningUserMenu(user);
            return;
        }
        else
        {
            Console.Clear();
        }
        do //nested do while loops to validate user inputs until validChoice is true at each collection point
        {
            Console.WriteLine($"\nEnter your systolic pressure, {user.UserName}:");
            systolicInput = Console.ReadLine();
            if (!int.TryParse(systolicInput, out systolic) || systolic < 0 || systolic > 300) //TryParse will return false if the input is not an integer
            {
                Console.WriteLine("\nSystolic pressure must be a number between 0 and 300. Please try again.");
            }
            else
            {
                break;
            }
        } while (true);

        do
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

        do
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

        do
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

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nThank you for the entry, {user.UserName}. It has been stored to your account!  If you would like to return to the Main Menu, please press Enter.  Otherwise type 'exit' to quit.");
        Console.ResetColor();
        string returnToMenu = Console.ReadLine().ToLower();

        if (returnToMenu == "exit" || returnToMenu == "no" || returnToMenu == "quit")
        {
            Console.Clear();
            Console.WriteLine($"\nThanks for visiting, {user.UserName}. Exiting your Account.");
            Environment.Exit(0);
            return;
        }

        else
        {
            Console.Clear();
            Console.WriteLine("Returning to Main Menu.");
            ReturningUserMenu(user); //returning to main menu if user does not exit program
        }
    }

    public static void UserCreationMenu() //method to create a new user
    {
        bool validChoice = true;
        string userInput = "";
        do
        {
            Console.WriteLine("\nWelcome! Please enter a User Name or hit Enter to return to Main Menu:");
            userInput = Console.ReadLine().Trim(); //collecting user name input


            if (String.IsNullOrEmpty(userInput)) //if user name is null or empty, it will return false
            {
                MainMenu mainMenu = new MainMenu(); //creating an instance of the main menu because we are returning to the main menu which isn't static
                mainMenu.StartMenu();
                validChoice = true;
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
        string initialInput;

        Console.Clear();
        Console.WriteLine($"Did you mean to select to delete an existing record, {user.UserName}? If so, type 'yes'.  Otherwise, hit Enter to go back to the User Menu.");
        initialInput = Console.ReadLine();

        if (initialInput.ToLower() == "yes" || initialInput.ToLower() == "y" || initialInput.ToLower() == "back" || initialInput.ToLower() == "return")
        {
            Console.Clear();
        }
        else
        {
            ReturningUserMenu(user);
            return;
        }

        Console.Clear();
        Console.WriteLine("Okay, let's delete a record.\n");
        Console.WriteLine("Please enter the date of the reading you would like to delete using one of the following formats - MM DD YYYY or MM-DD-YYYY:");
        while (!DateTime.TryParse(Console.ReadLine(), out dateInput))
        {
            Console.WriteLine("Invalid date, please enter a valid date:");
        }
        bool deleteSuccess = BloodPressureController.DeleteBloodPressureRecord(user.UserId, dateInput);
        if (deleteSuccess)
        {
            Console.WriteLine("\nYour record has been deleted from your account.");
        }
        else
        {
            Console.WriteLine("\nNo record was found for that date.");
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nIf you would like to return to the Main Menu, please press Enter.  Otherwise type 'exit' to quit.");
        Console.ResetColor();
        string returnToMenu = Console.ReadLine().ToLower();

        if (returnToMenu == "exit" || returnToMenu == "no" || returnToMenu == "quit")
        {
            Console.Clear();
            Console.WriteLine($"\nThanks for visiting, {user.UserName}. Exiting your Account.");
            Environment.Exit(0); //exits the program
            return;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Returning to Main Menu.");
            ReturningUserMenu(user); //returning to main menu if user does not exit program
        }
    }

    public static void ViewAllUserBpRecords(Guid userId, UserProfile user)
    {
        Console.Clear();
        List<BloodPressureRecord> userBpRecords = BloodPressureController.ViewAllUserBpRecords(userId);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Here are all of your previous readings:\n");
        Console.ResetColor();

        bool isEven = true;
        foreach (BloodPressureRecord bpRecord in userBpRecords)
        {
            if (isEven)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine($"Systolic: {bpRecord.Systolic} | Diastolic: {bpRecord.Diastolic} | Pulse: {bpRecord.Pulse} | Date: {bpRecord.Date}");
            isEven = !isEven;
        }
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nIf you would like to return to the Main Menu, please press Enter.  Otherwise type 'exit' to quit.");
        Console.ResetColor();
        string returnToMenu = Console.ReadLine().ToLower();

        if (returnToMenu == "exit" || returnToMenu == "no" || returnToMenu == "quit")
        {
            Console.Clear();
            Console.WriteLine($"\nThanks for visiting, {user.UserName}. Exiting your Account.");
            Environment.Exit(0); //exits the program
            return;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Returning to Main Menu.");
            ReturningUserMenu(user); //returning to main menu if user does not exit program
        }
    }
}