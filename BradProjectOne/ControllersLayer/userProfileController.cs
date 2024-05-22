namespace BradProjectOne.ControllersLayer;

using BradProjectOne.Models;
using BradProjectOne.DataAccessLayer;

public class UserProfileController
{
    //Here we will add an object to do access stuff with
    //We cannot instantiate an object representation of an interface
    //We can however, create an object of a class that implements the interface
    //and store it in a variable of the interface type
    private static IUserStorageRepo _userData = new SqlUserStorage();  //only need to change this now if we change the repository between JSON and SQL,

    public static UserProfile CreateUser(string userName)
    {
        UserProfile newUser = new UserProfile(userName); // Creates a new user profile from the model
        _userData.CreateUser(newUser); // Calls the create user method from the repository
        return newUser; // Returns the new user to the caller, which is the pre
    }

    public static bool UserExists(string userName) //method to check if user exists
    {
        if (_userData.RetrieveUser(userName) != null)
        {
            return true;
        }
        return false;
    }

    public static UserProfile GetUser(string userName) //method to get user
    {
        return _userData.RetrieveUser(userName);
    }
}