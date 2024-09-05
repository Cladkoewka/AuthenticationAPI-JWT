using authentication.Models;
using authentication.Services;
using Microsoft.AspNetCore.Mvc;

namespace authentication.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController(AccountService accountService) : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterUserRequest request)
    {
        accountService.Register(request.UserName, request.FirstName, request.Password);
        return NoContent();
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest loginRequest)
    {
        var token = accountService.Login(loginRequest.UserName, loginRequest.Password);
        return Ok(token);
    }
}