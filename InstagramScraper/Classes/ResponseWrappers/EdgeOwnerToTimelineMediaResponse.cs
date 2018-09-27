using Newtonsoft.Json;

namespace InstagramScraper.Classes.ResponseWrappers
{
    public class EdgeOwnerToTimelineMediaResponse
    {
        [JsonProperty("count")] public int Count { get; set; }
    }
}