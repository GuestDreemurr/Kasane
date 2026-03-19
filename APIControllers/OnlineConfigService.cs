using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/OnlineConfigService.svc")]

public class OnlineConfigService : ControllerBase
{
    /*
    [
  {
    "Name": "SandboxUrlWIIU",
    "Values": [
      "prudp:/address=mdc-mm-rdv21.ubisoft.com;port=22250"
    ]
  },
  {
    "Name": "SandboxUrlWS",
    "Values": [
      "mdc-mm-rdv21.ubisoft.com:22250"
    ]
  },
  {
    "Name": "uplay_DownloadServiceUrl",
    "Values": [
      "https://wsuplay.ubi.com/UplayServices/UplayFacade/DownloadServicesRESTXML.svc/REST/XML/?url="
    ]
  },
  {
    "Name": "uplay_DynContentBaseUrl",
    "Values": [
      "http://static8.cdn.ubi.com/u/Uplay/"
    ]
  },
  {
    "Name": "uplay_LinkappBaseUrl",
    "Values": [
      "http://static8.cdn.ubi.com/u/Uplay/Packages/linkapp/3.0.0-wiiu/"
    ]
  },
  {
    "Name": "uplay_MovieBaseUrl",
    "Values": [
      "http://static8.cdn.ubi.com/u/Uplay/"
    ]
  },
  {
    "Name": "uplay_PackageBaseUrl",
    "Values": [
      "http://static8.cdn.ubi.com/u/Uplay/Packages/1.5-Share-rc/"
    ]
  },
  {
    "Name": "uplay_ServiceLspPort",
    "Values": [
      "1081"
    ]
  },
  {
    "Name": "uplay_serviceLSPServerName",
    "Values": [
      "UBILSP1"
    ]
  },
  {
    "Name": "uplay_serviceLspServiceID",
    "Values": [
      "0x555307EF"
    ]
  },
  {
    "Name": "uplay_WebServiceBaseUrl",
    "Values": [
      "https://wsuplay.ubi.com/UplayServices/UplayFacade/ProfileServicesFacadeRESTXML.svc/REST/"
    ]
  }
]
    */
    [HttpGet("GetOnlineConfigWiiU")]
    public ActionResult<dynamic> GetOnlineConfigWiiU()
    {
        // TODO: make this all settable in appsettings.json
        return new[]
        {
            new 
            {
                SandboxUrlWIIU = "prudp:/address=mdc-mm-rdv21.ubisoft.com;port=22250",
                SandboxURLWS = "mdc-mm-rdv21.ubisoft.com:22250",
                uplay_DownloadServiceUrl = "http://wsuplay.ubi.com/UplayServices/UplayFacade/DownloadServicesRESTXML.svc/REST/XML/?url=",
                uplay_DynContentBaseUrl = "http://static8.cdn.ubi.com/u/Uplay/",
                uplay_LinkappBaseUrl = "http://static8.cdn.ubi.com/u/Uplay/Packages/linkapp/3.0.0-wiiu/",
                uplay_MovieBaseUrl = "http://static8.cdn.ubi.com/u/Uplay/",
                uplay_PackageBaseUrl = "http://static8.cdn.ubi.com/u/Uplay/Packages/1.5-Share-rc/",
                uplay_ServiceLspPort = "1081",
                uplay_serviceLSPServerName = "UBILSP1",
                uplay_serviceLspServiceID = "0x555307EF",
                uplay_WebServiceBaseUrl = "http://wsuplay.ubi.com/UplayServices/UplayFacade/ProfileServicesFacadeRESTXML.svc/REST/"
            }
        };
    }
    }