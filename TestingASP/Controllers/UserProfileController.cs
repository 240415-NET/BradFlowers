using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using TestingASP.Models;
using TestingASP.Services;

namespace TestingASP.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserProfileController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserProfileController(IUserService userServiceFromBuilder)
        {
            _userService = userServiceFromBuilder;
        }

        //Create a user in DB
        //Here we are going to create first controller method.
        //Needs HTTP verb tag, method signature that includes asnyc
        //this makes it asynchronous and meaning program won't lock up
        //waiting for someone's slow internet connection

        [HttpPost]
        public async Task<ActionResult<UserProfile>> PostNewUser(UserProfile newUserProfile)
        {
            //inside our controller we are going to call a method from our service class
            //We are going to wrap in try catch block to catch any exceptions so API doesn't go down
            //And we can inform the user they made a mistake

            try
            {

                //Inside of our try, we call the CreateNewUserProfileAsync method from our service
                //The service layer is going to handl validating the object meets our criteria
                await _userService.CreateNewUserProfileAsync(newUserProfileFromFrontend);

                //If it does, we return a 200 Ok success message and echo back the oject they gave us
                return Ok(newUserProfile);
                //if it fails we will hit the catch block

            }
            catch (Exception theException)
            {

                //If something goes wrong we are going to return a bad request
                    return BadRequest(theException.Message);
            }

            
        }



    }
}

