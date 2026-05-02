using System.Xml.Serialization;
public partial class FriendsService
{


    [XmlRoot("ArrayOfExternalAccountInfoClient", Namespace = "http://schemas.datacontract.org/2004/07/Ubisoft.ProfileService.Contracts")]
    public class GetShareUsersAccountsResponse
    {
        [XmlElement("ExternalAccountInfoClient")]
        public List<ExternalAccountInfoClient> Accounts { get; set; }
    }

    public class ExternalAccountClient
    {
        public string ExternalAccountId { get; set; }
    }

    [XmlRoot("ArrayOfExternalAccountClient", Namespace = "http://schemas.datacontract.org/2004/07/Ubisoft.Uplay.UplayShare.Services.Contracts.Client")]
    public class GetShareUsersAccountsRequest
    {
        [XmlElement("ExternalAccountClient")]
        public List<ExternalAccountClient> Accounts { get; set; }
    }


    public class ExternalAccountInfoClient
    {
        public bool IsUbiUser { get; set;} = true; // always true, i think this is ubi as in ubisoft club? no clue..
        public bool IsUplayUser { get; set; } = true;
        public int AvatarId { get; set; }
        public required string Quote { get; set; }
        public int UserId { get; set; } // probably a uuid based off other server impls, but we arent working with a db, YET.
        public required string ExternalAccountId { get; set; } // for wii u this is PNID/NNID. for x360/ps3 its gamertag/psn.
        public required string LastPlayedGameCode { get; set; }
        public DateTime LastSeenDate { get; set; }
        public int UnitsSpent { get; set; }
        public int UnitsWon { get; set; }
        public required string LastActionCompletedCode { get; set; }
        public required string LastActionCompletedGameCode { get; set; }
        public required string LastRewardBoughtCode { get; set; }
        public required string LastRewardBoughtGameCode { get; set; }
        public required string LastFeedPriority { get; set; }
        public required string LastFeedGameCode { get; set; }
        public int LastFeedElapsedSeconds { get; set; }
        public DateTime LastFeedCreatedDate { get; set; }

    }
}