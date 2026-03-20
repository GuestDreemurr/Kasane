using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/OnlineConfigService.svc")]
public class OnlineConfigService : ControllerBase
{
  [HttpGet("GetOnlineConfigWiiU")]
  public ActionResult<dynamic> GetOnlineConfigWiiU(string onlineConfigID)
  {
    Console.WriteLine($"[OnlineConfigService] Client Id: {onlineConfigID}");

    switch (onlineConfigID)
    {
      // Uplay
      case "602922fcd2eb4b18a7fa4252ffc7b75f":
        string data = Utils.ReadJsonFromFile(Path.Combine(Settings.JsonTemplatePath, "Uplay.json"));
        return data;
      // ZombiU
      case "dc580a8b83764dd6ac2d05d4321bc113":
        string zombidata = Utils.ReadJsonFromFile(Path.Combine(Settings.JsonTemplatePath, "ZombiU.json"));
        return Content(zombidata, "application/json");
    }

    return new[]
    {
            new { Name = "SandboxUrlWIIU",             Values = new[] { "prudp:/address=mdc-mm-rdv21.ubisoft.com;port=22250" } },
            new { Name = "SandboxUrlWS",               Values = new[] { "mdc-mm-rdv21.ubisoft.com:22250" } },
            new { Name = "uplay_DownloadServiceUrl",   Values = new[] { "http://wsuplay.ubi.com/UplayServices/UplayFacade/DownloadServicesRESTXML.svc/REST/XML/?url=" } },
            new { Name = "uplay_DynContentBaseUrl",    Values = new[] { "http://static8.cdn.ubi.com/u/Uplay/" } },
            new { Name = "uplay_LinkappBaseUrl",       Values = new[] { "http://static8.cdn.ubi.com/u/Uplay/Packages/linkapp/3.0.0-wiiu/" } },
            new { Name = "uplay_MovieBaseUrl",         Values = new[] { "http://static8.cdn.ubi.com/u/Uplay/" } },
            new { Name = "uplay_PackageBaseUrl",       Values = new[] { "http://static8.cdn.ubi.com/u/Uplay/Packages/1.5-Share-rc/" } },
            new { Name = "uplay_ServiceLspPort",       Values = new[] { "1081" } },
            new { Name = "uplay_serviceLSPServerName", Values = new[] { "UBILSP1" } },
            new { Name = "uplay_serviceLspServiceID",  Values = new[] { "0x555307EF" } },
            new { Name = "uplay_WebServiceBaseUrl",    Values = new[] { "http://wsuplay.ubi.com/UplayServices/UplayFacade/ProfileServicesFacadeRESTXML.svc/REST/" } },
        };
  }
}