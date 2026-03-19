using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

[ApiController]
//[Route(BaseURL)]
public class ShopService : ProfileService
{
    [HttpGet("XML/GetShopProductSections/{platformCode}/{culture}")]
    public ActionResult<dynamic> GetShopProductSections(string platformCode, string culture)
    {
        string path = Path.Combine(Settings.TemplatesPath, "getshopproductsections.xml");
        XDocument xmlDoc = Utils.LoadXmlFromFile(path);
       
        if (xmlDoc == null)
        {
            return NotFound();
        }
        return Content(xmlDoc.ToString(), "application/xml");
            
    }
}