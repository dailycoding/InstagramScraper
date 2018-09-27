using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramScraper.Classes.ResponseWrappers
{
    public class InstaUserInfoResponse
    {
        [JsonProperty("username")] public string Username { get; set; }

        [JsonProperty("full_name")] public string FullName { get; set; }

        [JsonProperty("is_private")] public bool IsPrivate { get; set; }

        [JsonProperty("profile_pic_url")] public string ProfilePicUrl { get; set; }

        [JsonProperty("profile_pic_url_hd")] public string ProfilePicUrlHd { get; set; }

        [JsonProperty("is_verified")] public bool IsVerified { get; set; }

        [JsonProperty("edge_owner_to_timeline_media")] public EdgeOwnerToTimelineMediaResponse Media { get; set; }

        [JsonProperty("edge_followed_by")] public EdgeFollowedByResponse FollowedBy { get; set; }

        [JsonProperty("edge_follow")] public EdgeFollowResponse Follow { get; set; }

        [JsonProperty("biography")] public string Biography { get; set; }

        [JsonProperty("external_url")] public string ExternalUrl { get; set; }

        [JsonProperty("external_url_linkshimmed")] public string ExternalUrlLinkshimmed { get; set; }

        [JsonProperty("is_business_account")] public bool IsBusiness { get; set; }
    }
}