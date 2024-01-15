using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Model.DTOs;
using WeatherAPI.Model.Entities;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser([FromBody] UserToAddDTO user)
        {
            if (ModelState.IsValid)
            {
                var userExit = await _userManager.FindByEmailAsync(user.Email);
                if (userExit != null) return BadRequest(new ReturnObject<string>
                {
                    Success = false,

                });


            }
        }

    }
}
