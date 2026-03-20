using Microsoft.AspNetCore.Mvc;

[ApiController]
public class TrackingService : ProfileService
{
    [HttpPost("XML/UpdateUserApplicationTracking/{userId}")]
    public ActionResult<dynamic> UpdateUserApplicationTracking()
    {
        return Ok(); // returns 200, thats literally all it fucking does LMAO
        // pretty sure this would of done something on the backend on real uplay but honestly who gives a damn, this is just telemetry
    }
}