using TestingASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace TestingASP.DataAccessLayer;

public class UserStorageEFRepo : IUserStorageEFRepo
{
    private readonly TestingASPContext _context;

    public UserStorageEFRepo(TestingASPContext contextFromBuilder)
    {
        _context = contextFromBuilder;

    }

    public async Task<UserProfile?> CreateUserInDbAsync(UserProfile newUserSentFromUserService)
    {
        return newUserSentFromUserService;

    }



}
