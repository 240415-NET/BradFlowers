namespace BradProjectOne.PresentationLayer
{
    public class UserMenu
    {
        public static void returningUserMenu()
        {
            int returnMenuChoice = 0;  // collecting choice inputs
            bool validChoice = true; // validating choice inputs to continue or break in switch statement

            Console.WriteLine("\nPlease select an option:");
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
                                Console.WriteLine("Enter your systolic pressure:");
                                systolicInput = Console.ReadLine();
                                if (!int.TryParse(systolicInput, out systolic) || systolic < 0 || systolic > 300)
                                {
                                    Console.WriteLine("Diastolic pressure must be a number between 0 and 200. Please try again.");
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);

                            do //nested do while loops to validate user inputs until validChoice is true at each collection point
                            {
                                Console.WriteLine("Enter your diastolic pressure:");
                                diastolicInput = Console.ReadLine();
                                if (!int.TryParse(diastolicInput, out diastolic) || diastolic < 0 || diastolic > 200)
                                {
                                    Console.WriteLine("Diastolic pressure must be a number between 0 and 200. Please try again.");
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);

                            do //nested do while loops to validate user inputs until validChoice is true at each collection point
                            {
                                Console.WriteLine("Enter your pulse:");
                                pulseInput = Console.ReadLine();
                                if (!int.TryParse(pulseInput, out pulse) || pulse < 0 || pulse > 300)
                                {
                                    Console.WriteLine("Pulse must be a number between 0 and 300. Please try again.");
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);

                            do //nested do while loops to validate user inputs until validChoice is true at each collection point
                            {
                                Console.WriteLine("Enter the date of the reading using one of the following formats - MM DD YYYY or MM-DD-YYYY:");
                                dateInput = Console.ReadLine();
                                if (!DateTime.TryParse(dateInput, out date) || date > DateTime.Now)
                                {
                                    Console.WriteLine("Date must be one of the following formats - MM DD YYYY or MM-DD-YYYY, and cannot be in the future. Please try again.");
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
                            Console.WriteLine("Exiting program");
                            validChoice = true;
                            
                            return;

                        default:
                            Console.WriteLine("Please enter a valid number.");
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
    }
}