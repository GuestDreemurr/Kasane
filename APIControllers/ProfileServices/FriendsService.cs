using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;


[ApiController]
public class FriendsService : ProfileService
{
    [HttpPost("XML/GetShareUsersAccounts/{platformCode}")]
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
}