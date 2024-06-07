using TestingASP.Models;

namespace TestingASP.Services;

public class UserService : IUserService
{
    //The same way our UserService is given to our UserProfileController via dependency injection
    //We need to strore our data access object for database interaction
    //relating to the UserProfile Model.  We will create private readonly
    //objects that we don't create using "new"

    private readonly IUserStorageEFRepo _userStorage;

    public UserService(IUserStorageEFRepo efRepoFromBuilder)
    {
        _userStorage = efRepoFromBuilder;
    }

    //Creating method to hold business logic for creating a new user.
    //Called by UserProfileController's PostNewUser method
    //and it will then call the EFRepo's CreateNewUserProfileAsync method

    public async Task CreateNewUserProfileAsync(UserProfile newUserSentFromController)
    {
        //We are going to call the EFRepo's CreateNewUserProfileAsync method
        //This method is going to handle the actual database interaction
        //We are going to pass the newUser
}