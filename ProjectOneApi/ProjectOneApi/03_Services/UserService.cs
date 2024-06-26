using System.Data.SqlTypes;
using ProjectOneApi.Models;
using ProjectOneApi.DataAccessLayer;


namespace ProjectOneApi.Services;

public class UserService : IUserService
{
    private readonly IUserStorageEFRepo _userStorage;



    public UserService(IUserStorageEFRepo efRepoFromBuilder)
    {
        _userStorage = efRepoFromBuilder;
    }

    public async Task<UserProfile> CreateNewUserInDBAsync(UserProfile newUserSentFromController)
    {
        if (await UserExistsAsnyc(newUserSentFromController.UserName) == true)
        {
            throw new Exception("User already exists");
        }

        if (string.IsNullOrEmpty(newUserSentFromController.UserName) == true)
        {
            throw new Exception("Username cannot be blank");
        }

        await _userStorage.CreateNewUserInDBAsync(newUserSentFromController);

        return newUserSentFromController;

    }

    public async Task<UserProfile> GetUserByUsernameAsync(string usernameToFindFromController)
    {
        if (string.IsNullOrEmpty(usernameToFindFromController) == true)
        {
            throw new Exception("Username cannot be blank");
        }

        try
        {
            UserProfile? foundUser = await _userStorage.GetUserFromDBByUsernameAsync(usernameToFindFromController);

            if (foundUser == null)
            {
                throw new Exception("User not found in DB");
            }
            return foundUser;

        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }

    }

    public async Task<string> DeleteByUserNameAsync(string usernameToDeleteFromController)
    {
        if (await UserExistsAsnyc(usernameToDeleteFromController) == true)
        {
            await _userStorage.DeleteUserFromDBAsync(usernameToDeleteFromController);
        }
        else
        {
            throw new Exception("User not found. Cannot be deleted");
        }

        return usernameToDeleteFromController;


    }
    public async Task<bool> UserExistsAsnyc(string usernameToFindFromController)
    {

        return await _userStorage.DoesThisUserExistOnDBAsync(usernameToFindFromController);
    }

    //Method in our service layer when called by the controller to update a user's username
    //service layer will call the data access layer for a method to do the actual updating

    public async Task<string> UpdateUsernameAsnyc(UsernameUpdateDTO usernamesToSwapFromController)
    {
        return await _userStorage.UpdateUserInDBAsync(usernamesToSwapFromController);

    }


}

