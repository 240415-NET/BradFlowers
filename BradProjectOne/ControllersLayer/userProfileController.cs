using BradProjectOne.Models;
using BradProjectOne.PresentationLayer;

namespace BradProjectOne.ControllersLayer
{
    public class UserProfileController
    {
        public static void CreateUser(string userName)
        {

            UserProfile newUser = new UserProfile(userName); // Creates a new user profile from the model

        }

        public static bool UserExists(string userName)
        {
            return false;
        }


        public static void GetReturningUser()
        {

        }


    }
}