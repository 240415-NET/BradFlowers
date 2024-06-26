using Microsoft.AspNetCore.Mvc;
using ProjectOneApi.Models;
using ProjectOneApi.Services;

namespace ProjectOneApi.Controllers;

[ApiController]

public class UserProfileController : ControllerBase
{
    private readonly IUserService _userService;

    public UserProfileController(IUserService userServiceFromBuilder)
    {
        _userService = userServiceFromBuilder;
    }

    //Creating User from DB
    [HttpPost("users/{userName}")]
    public async Task<ActionResult<UserProfile>> PostNewUser(string userName)
    {

        try
        {
            UserProfile newUser = new UserProfile(userName);

            //Inside our try we call the createNewUserAsync method from our userService
            await _userService.CreateNewUserInDBAsync(newUser);

            //Ok returns a 200 status code
            return Ok(newUser);

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }


    }

    //GET method to return a single user from our DB based on the username passed in from frontend

    [HttpGet("/Users/{usernameToFindFromFrontEnd}")]
    public async Task<ActionResult<UserProfile>> GetUserByUsername(string usernameToFindFromFrontEnd)
    {
        //Again, we are going to start with a try catch, so that we can NOT crash our API if something goes wrong,
        //and ideally, we can inform the front end so it can inform the user
        try
        {
            return await _userService.GetUserByUsernameAsync(usernameToFindFromFrontEnd);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpDelete("/Users/{userNameToDeleteFromFrontEnd}")]

    public async Task<ActionResult<UserProfile>> DeleteUserByUsername(string userNameToDeleteFromFrontEnd)
    {
        try
        {
            await _userService.DeleteByUserNameAsync(userNameToDeleteFromFrontEnd);
            //If all goes well we will return a 200 Ok status code to the frontend
            return Ok($"{userNameToDeleteFromFrontEnd} has been deleted from the DB");
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
    
    [HttpPatch("/Users/usernamesToSwap")]
    public async Task<ActionResult> UpdateUserByUsername(UsernameUpdateDTO usernamesToSwap)
    {
        try
        {
            await _userService.UpdateUsernameAsnyc(usernamesToSwap);

            return Ok($"{usernamesToSwap.OldUsername} has been updated to {usernamesToSwap.NewUsername}");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    
    }

    //here we will create an HTTP PATCH
    //This will allow us to update someone's usename without having to delete and recreate the user



}

