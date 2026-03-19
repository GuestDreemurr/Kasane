using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;


[ApiController]
public class FriendsService : ProfileService
{
    [HttpGet("XML/GetShareUsersAccounts/{platformCode}")]
    public ActionResult<dynamic> GetShareUsersAccounts(string platformCode)
    {
        string path = Path.Combine(Settings.TemplatesPath, "getshareusersaccounts.xml");
        XDocument xmlDoc = Utils.LoadXmlFromFile(path);
        if (xmlDoc == null)
       {
           return NotFound();
       }
       return Content(xmlDoc.ToString(), "application/xml");
    }
    [HttpGet("XML/GetShareUsersGlobalStatsAggregated/{user_id}/{cultureCode}")]
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
}