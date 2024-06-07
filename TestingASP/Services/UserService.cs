using TestingASP.Models;

namespace TestingASP.Services;

public class UserService : IUserService
{
    //The same way our UserService is given to our UserProfileController via dependency injection
    //We need to strore our data access object for database interaction
    //relating to the UserProfile Model.  We will create private readonly
    //objects that we don't create using "new"

    //private readonly IUserStorageEFRepo _userStorage;

    public UserService()
    {
        //_userStorage = efRepoFromBuilder;
    }

    //Creating method to hold business logic for creating a new user.
    //Called by UserProfileController's PostNewUser method
    //and it will then call the EFRepo's CreateNewUserProfileAsync method

    public async Task<UserProfile> CreateNewUserProfileAsync(UserProfile newUserSentFromController)
    {
        //We are going to call the EFRepo's CreateNewUserProfileAsync method
        //This method is going to handle the actual database interaction
        //We are going to pass the newUser

        //Rules for creating new user
        //1. No duplicates
        //2. No empty or blank

        //We will eventually need to call DataAcessLayer to check if user exists

        if (UserExists(newUserSentFromController.UserName) == true)
        {
            throw new Exception("User already exists");
        }

        if(string.IsNullOrEmpty(newUserSentFromController.UserName) == true)
                {
            throw new Exception("Username cannot be blank");
        }
        //await _userStorage.CreateUserInDbAsync(newUserSentFromController);
        return newUserSentFromController;
}

public bool UserExists(string userProfile) 
{   
    return false;
}
}