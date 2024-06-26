using TestingASP.Models;
using Microsoft.EntityFrameworkCore;


namespace TestingASP.DataAccessLayer
{
    public interface IUserStorageEFRepo
    {
        public Task<UserProfile?> CreateUserInDbAsync(UserProfile newUserSentFromUserService);
    }
}

