using Newtonsoft.Json;

namespace InstagramScraper.Classes.ResponseWrappers
{
    public class EdgeFollowResponse
    {
        [JsonProperty("count")] public int Count { get; set; }
    }
}