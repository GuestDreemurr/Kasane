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
    [HttpPost("XML/GetShareUsersGlobalStatsAggregated/{user_id}/{cultureCode}")]
    public ActionResult<dynamic> GetShareUsersGlobalStatsAggregated(long user_id, string cultureCode)
    {
        string path = Path.Combine(Settings.TemplatesPath, "getshareusersglobalstats.xml");
        XDocument xmlDoc = Utils.LoadXmlFromFile(path);
        if (xmlDoc == null)
        {
            return NotFound();
        }
        return Content(xmlDoc.ToString(), "application/xml");
    }
    [HttpGet("XML/GetShareNewReleases/{uid}/{cultureCode}")]
    public ActionResult<dynamic> GetShareNewReleases(long uid, string cultureCode)
    {
        string path = Path.Combine(Settings.TemplatesPath, "getsharenewreleases.xml");
        XDocument xmlDoc = Utils.LoadXmlFromFile(path);
        if (xmlDoc == null)
        {
            return NotFound();
        }
        return Content(xmlDoc.ToString(), "application/xml");
    }
}