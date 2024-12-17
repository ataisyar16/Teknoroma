using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.WebAPI.Models;
using Teknoroma.WebAPI.Models.DTOs; // DTO modellerini buraya koyacağız

namespace Teknoroma.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Register metodu
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            var user = new AppUser
            {
                UserName = registerDTO.UserName,
                Email = registerDTO.Email,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName
            };

            var result = await _userManager.CreateAsync(user, registerDTO.Password);

            if (result.Succeeded)
            {
                return Ok("Kayıt Başarılı!");
            }

            return BadRequest(result.Errors);
        }

        // Login metodu
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByNameAsync(loginDTO.Email);

            if (user == null)
                return BadRequest("Kullanıcı bulunamadı!");

            var result = await _signInManager.PasswordSignInAsync(user, loginDTO.Password, true, false);

            if (result.Succeeded)
            {
                return Ok($"Hoşgeldiniz, {user.FirstName}!");
            }

            return Unauthorized("Hatalı kullanıcı adı veya şifre.");
        }
    }
}
