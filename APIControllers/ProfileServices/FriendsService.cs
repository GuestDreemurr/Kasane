using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;


[ApiController]
public partial class FriendsService : ProfileService
{
    [HttpPost("XML/GetShareUsersAccounts/{platformCode}")]
    public async Task<ActionResult> GetShareUsersAccounts(string platformCode)
    {
        using var reader = new StreamReader(Request.Body);
        var body = await reader.ReadToEndAsync();

        var requestSerializer = new XmlSerializer(typeof(GetShareUsersAccountsRequest));
        using var stringReader = new StringReader(body);
        var request = (GetShareUsersAccountsRequest)requestSerializer.Deserialize(stringReader);
        if (request == null){
            return StatusCode(403);
        }

        var ids = request.Accounts.Select(a => a.ExternalAccountId).ToList();
        Console.WriteLine($"Received GetShareUsersAccounts request for platform {platformCode} with accounts: {string.Join(", ", ids)}");

        var response = new GetShareUsersAccountsResponse
        {
            Accounts = ids.Select(id => new ExternalAccountInfoClient
            {
                IsUbiUser = true,
                IsUplayUser = true,
                AvatarId = 1,
                Quote = "Hello World",
                UserId = new Random().Next(1, 1000),
                ExternalAccountId = id,
                LastPlayedGameCode = "AC3",
                LastSeenDate = DateTime.UtcNow,
                UnitsSpent = 100,
                UnitsWon = 50,
                LastActionCompletedCode = "ACTION_CODE",
                LastActionCompletedGameCode = "AC3",
                LastRewardBoughtCode = "REWARD_CODE",
                LastRewardBoughtGameCode = "AC3",
                LastFeedPriority = "PRIORITY",
                LastFeedGameCode = "AC3",
                LastFeedElapsedSeconds = 100,
                LastFeedCreatedDate = DateTime.UtcNow
            }).ToList()
        };

        var responseSerializer = new XmlSerializer(typeof(GetShareUsersAccountsResponse));
        using var stringWriter = new StringWriter();
        responseSerializer.Serialize(stringWriter, response);
        return Content(stringWriter.ToString(), "application/xml");
    }
}