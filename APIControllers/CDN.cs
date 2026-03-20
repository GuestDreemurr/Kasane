using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class CDN : ControllerBase
{
    [HttpGet("/gamesites/uplay/201211261811/img/avatar/no_tall.png")]
    [HttpGet("/{userId}/default_tall.png")]
    public ActionResult<dynamic> GetUserIcon(long userId)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imgs", "default_tall.png");
        return PhysicalFile(path, "image/png"); // just a way to handle until we have a database
    }
    
}