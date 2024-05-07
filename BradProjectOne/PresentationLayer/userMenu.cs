namespace BradProjectOne.PresentationLayer
{
    public class UserMenu
    {
        public static void returningUserMenu()
        {
            int returnMenuChoice = 0;
            bool validChoice = true;

            Console.WriteLine("Welcome back! Please select an option:");
            Console.WriteLine("1 Enter new blood pressure reading");
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
                        case 1:  // review exceptions and see if I can't get it loop back to question if invalid input.
                                 //Ie. systolic is outside of range, re-ask for input.
                                
                            Console.WriteLine("Please enter your new blood pressure reading");
                            Console.WriteLine("Enter your systolic pressure:");
                            int systolic = Convert.ToInt32(Console.ReadLine());
                            if (systolic < 0 || systolic > 300)
                            {
                                throw new Exception("Systolic pressure must be between 0 and 300.");
                            }
                                                    
                            Console.WriteLine("Enter your diastolic pressure:");
                            int diastolic = Convert.ToInt32(Console.ReadLine());
                            if (diastolic < 0 || diastolic > 300)
                            {
                                throw new Exception("Diastolic pressure must be between 0 and 300.");
                            }

                            Console.WriteLine("Enter your pulse:");
                            int pulse = Convert.ToInt32(Console.ReadLine());
                            if (pulse < 0 || pulse > 300)
                            {
                                throw new Exception("Pulse must be between 0 and 300.");
                            }

                            Console.WriteLine("Enter the date of the reading using one of the following formats - MM DD YYYY or MM-DD-YYYY:");
                            DateTime date = Convert.ToDateTime(Console.ReadLine());
                            if (date > DateTime.Now)
                            {
                                throw new Exception("Date cannot be in the future.");
                            }
                                                        
                            validChoice = true;
                            break;

                        case 2:
                            Console.WriteLine("DISPLAY ALL PREVIOUS READINGS HERE"); // Placeholder
                            validChoice = true;  //Would you like to return to the main menu or exit at this point option.
                            break;

                        case 3:
                            Console.WriteLine("DELETE A PREVIOUS ENTRY HERE"); // Placeholder
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