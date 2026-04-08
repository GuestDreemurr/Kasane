using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

[ApiController]

public class BootstrapService : ProfileService
{

    // known as the UplayUserId api internally.
    [HttpGet("XML/{user_id}/{platform_code}/{game_code}/{culture}")]
    public ActionResult<dynamic> SetupBootstrapService(string user_id, string platform_code, string game_code, string culture)
    {
        // dunno how to handle, return 403
        if (user_id != "UplayUserId")
        {
            return StatusCode(403);
        }
        string path = Path.Combine(Settings.TemplatesPath, "user.xml");
        XDocument xmlDoc = Utils.LoadXmlFromFile(path);
        if (xmlDoc == null)
        {
            return NotFound();
        }
        return Content(xmlDoc.ToString(), "application/xml");
    
    }
}