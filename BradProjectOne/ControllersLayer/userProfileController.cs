using BradProjectOne.Models;

namespace BradProjectOne.ControllersLayer
{
    public class userProfileController
    {
        public static void createUser(string userName)
        {

            UserProfile newUser = new UserProfile(userName); // Creates a new user profile from the model

        }
        public static void getReturningUser()
        {

        }


    }
}