using Newtonsoft.Json;

namespace InstagramScraper.Classes.ResponseWrappers
{
    public class InstaUserInfoContainerResponse
    {
        [JsonProperty("user")] public InstaUserInfoResponse User { get; set; }
    }
}