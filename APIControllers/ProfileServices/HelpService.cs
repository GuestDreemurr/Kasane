using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

[ApiController]
public class HelpService : ProfileService
{
    [HttpGet("XML/getHelpSections/{game_code}/{platform_code}/{culture}")]
    public ActionResult<dynamic> GetHelpSections(string game_code, string platform_code, string culture)
    {
        string path = Path.Combine(Settings.TemplatesPath, "gethelpsections.xml");
        XDocument xmlDoc = Utils.LoadXmlFromFile(path);
        if (xmlDoc == null)
        {
            return NotFound();
        }
        return Content(xmlDoc.ToString(), "application/xml");
    }
}