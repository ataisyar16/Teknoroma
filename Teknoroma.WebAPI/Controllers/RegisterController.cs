using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.WebAPI.Models;

[Route("api/register")]
[ApiController]
public class RegisterController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;

    public RegisterController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterDTO model)
    {
        var user = new AppUser
        {
            UserName = model.UserName,
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            return Ok("Registration successful");
        }

        return BadRequest(result.Errors);
    }
}
