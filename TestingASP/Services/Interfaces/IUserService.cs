using TestingASP.Models;

namespace TestingASP.Services
{
    public interface IUserService
    {
        public Task<UserProfile> CreateNewUserProfileAsync(UserProfile newUserSentFromController);

    }
}