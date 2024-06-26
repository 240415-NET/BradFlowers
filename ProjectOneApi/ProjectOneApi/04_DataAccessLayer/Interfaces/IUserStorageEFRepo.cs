using ProjectOneApi.Models;

namespace ProjectOneApi.DataAccessLayer;

public interface IUserStorageEFRepo
{
    public Task<UserProfile?> CreateNewUserInDBAsync(UserProfile newUserSentFromUserService);
    public Task<UserProfile?> GetUserFromDBByUsernameAsync(string usernameToFindFromService);
    public Task<bool> DoesThisUserExistOnDBAsync(string usernameToFindFromService);
    public Task<string> DeleteUserFromDBAsync(string usernameToDeleteFromService);
    public Task<string> UpdateUserInDBAsync(UsernameUpdateDTO usernamesToSwapFromUserService);
}
