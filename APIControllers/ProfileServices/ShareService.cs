using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

[ApiController]
public class ShareService : ProfileService
{
    [HttpGet("XML/GetGifts/{culture}")]
    public ActionResult<dynamic> GetGifts(string culture)
    {
        string path = Path.Combine(Settings.TemplatesPath, "getgifts.xml");
        XDocument xmlDoc = Utils.LoadXmlFromFile(path);
        if (xmlDoc == null)
        {
            return NotFound();
        }
        return Content(xmlDoc.ToString(), "application/xml");
        
    }
}