using BradProjectOne.Models;
using BradProjectOne.PresentationLayer;
using BradProjectOne.DataAccessLayer;

namespace BradProjectOne.ControllersLayer
{
    public class UserProfileController
    {
        public static void CreateUser(string userName)
        {
            UserProfile newUser = new UserProfile(userName); // Creates a new user profile from the model
            UserRepository.createUser(newUser); // Calls the create user method from the repository

        }

        public static bool UserExists(string userName)
        {
            
            if (UserRepository.RetrieveUser(userName) != null)
            {
                return true;
            }
            
            return false;
        }


        // public static void GetReturningUser()
        // {

        // }


    }
}