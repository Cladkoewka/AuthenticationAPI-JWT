using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authentication.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class MovieController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMovies()
    {
        return Ok(new List<object>
        {
            new
            {
                Name = "Forrest gump",
                Duration = TimeSpan.FromHours(2)
            },
            new
            {
                Name = "Movie 43",
                Duration = TimeSpan.FromHours(3)
            }
        });

    }
}