using Newtonsoft.Json;

namespace InstagramScraper.Classes.ResponseWrappers
{
    public class EdgeFollowedByResponse
    {
        [JsonProperty("count")] public int Count { get; set; }
    }
}