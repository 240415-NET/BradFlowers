using ProjectOneApi.Models;

namespace ProjectOneApi.Services;

public interface IUserService
{
    public Task<UserProfile> CreateNewUserInDBAsync(UserProfile newUserFromController);
    public Task<UserProfile> GetUserByUsernameAsync(string usernameToFindFromController);
    public Task<string> DeleteByUserNameAsync(string usernameToDeleteFromController);
    public Task<string> UpdateUsernameAsnyc(UsernameUpdateDTO usernamesToSwapFromController);
}
