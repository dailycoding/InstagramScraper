using System.Collections.Generic;

namespace InstagramScraper.Classes.Models
{
    public class InstaUserInfo
    {
        public string Username { get; set; }

        public string FullName { get; set; }

        public bool IsPrivate { get; set; }

        public string ProfilePicUrl { get; set; }

        public bool IsVerified { get; set; }

        public long MediaCount { get; set; }

        public long FollowerCount { get; set; }

        public long FollowingCount { get; set; }

        public string Biography { get; set; }

        public string ExternalUrl { get; set; }

        public string ExternalUrlLinkshimmed { get; set; }
    }
}