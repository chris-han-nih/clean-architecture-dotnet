namespace Api.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HealthController: ControllerBase
{
    [HttpGet]
    [Route("/")]
    public IActionResult Get()
    {
        return Ok("Healthy");
    }
}