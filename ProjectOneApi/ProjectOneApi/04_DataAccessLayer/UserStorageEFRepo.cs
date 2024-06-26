using ProjectOneApi.Models;
//using ProjectOneApi.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;

namespace ProjectOneApi.DataAccessLayer;

public class UserStorageEFRepo : IUserStorageEFRepo
{
    private readonly ProjectOneApiContext _context;
    public UserStorageEFRepo(ProjectOneApiContext contextFromBuilder)
    {
        _context = contextFromBuilder;
    }
    public async Task<UserProfile?> CreateNewUserInDBAsync(UserProfile newUserSentFromUserService)
    {


        //Here we will actually create the user in the DB

        _context.UserProfiles.Add(newUserSentFromUserService);

        //This line saves the changes to the DB
        await _context.SaveChangesAsync();


        return newUserSentFromUserService;
    }

    public async Task<UserProfile?> GetUserFromDBByUsernameAsync(string usernameToFindFromUserService)
    {
        //We are going to attempt to find the user in the DB based on the string
        //In this method call we are asking LINQ for a singlenpm install --save-dev jest @types/jest ts-jest user based on it's username matching the usernameToFindFromService we passed in
        UserProfile? foundUser = await _context.UserProfiles.SingleOrDefaultAsync(user => user.UserName == usernameToFindFromUserService);

        return foundUser;

    }

    //New Method using the .Any() LINQ method to check if a user exists in the DB
    //This method will return a boolean value. It doesn't care about returning sort user of user object
    //or information on a user if they exist.  Just  whether or not they exist at all.

    public async Task<bool> DoesThisUserExistOnDBAsync(string usernameToFindFromService)
    {

        //We are going to call the .Any() method which returns a boolean/false
        //if the user exists in the DB, it resolves to true
        //otherwise it resolves to false

        return await _context.UserProfiles.AnyAsync(user => user.UserName == usernameToFindFromService);
    }

    public async Task<string> DeleteUserFromDBAsync(string usernameToDeleteFromService)
    {
        //We are going to remove the user from the DB based on the username
        //we call the .Remove() method on the UserProfiles DbSet
        //instead of going thru the steps to find the user first, we call the GetUserFromDBByUsernameAsync method
        //that was created earlier and reuse it

        UserProfile? userToDelete = await GetUserFromDBByUsernameAsync(usernameToDeleteFromService);

        _context.UserProfiles.Remove(userToDelete);

        await _context.SaveChangesAsync();

        return usernameToDeleteFromService;

    }

    public async Task<string> UpdateUserInDBAsync(UsernameUpdateDTO usernamesToSwapFromUserService)
    {
        UserProfile? userToUpdate = await _context.UserProfiles.SingleOrDefaultAsync(user => user.UserName == usernamesToSwapFromUserService.OldUsername);

        if (userToUpdate == null)
        {
            throw new Exception("User to update not found in DB");
        }
        else
        {
            userToUpdate.UserName = usernamesToSwapFromUserService.NewUsername;
        }

        await _context.SaveChangesAsync();
        return usernamesToSwapFromUserService.NewUsername;


    }

}
