using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/OnlineConfigService.svc")]
public class OnlineConfigService : ControllerBase
{
  [HttpGet("GetOnlineConfigWiiU")]
  public ActionResult<dynamic> GetOnlineConfigWiiU(string onlineConfigID, string wiiuTicket)
  {
    Console.WriteLine($"[OnlineConfigService] Config Id: {onlineConfigID}");
    Console.WriteLine($"[OnlineConfigService] Wii U Service Token: {wiiuTicket}");

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
      // Assassin's Creed III
      case "b7b3206e47a64ff5ad49f73918e36505":
        string ac3data = Utils.ReadJsonFromFile(Path.Combine(Settings.JsonTemplatePath, "AC3.json"));
        return Content(ac3data, "application/json");
      // Assassin's Creed III Multiplayer, for some reason ubisoft split this, so AC3.json should just be uplay integration?
      case "1e6aa0140a8c4310bdfcaaf46e3a4fd8":
        string ac3multiplayerdata = Utils.ReadJsonFromFile(Path.Combine(Settings.JsonTemplatePath, "AC3Multiplayer.json"));
        return Content(ac3multiplayerdata, "application/json");
      // ESPN Sports Connection
      case "79ae3eef42384c70a25f610eef794560":
        string espndata = Utils.ReadJsonFromFile(Path.Combine(Settings.JsonTemplatePath, "ESPNSportsConnection.json"));
        return Content(espndata, "application/json");
        // Rabbids Land
      case "b9a657998c2345b68823fab56bf1e682":
        string rabbidslanddata = Utils.ReadJsonFromFile(Path.Combine(Settings.JsonTemplatePath, "RabbidsLand.json"));
        return Content(rabbidslanddata, "application/json");
    }

    return NotFound(); // unknown config, throwing 404 should make the client throw a error in most cases? dunno how ubisoft handles this lmao.

  }
}