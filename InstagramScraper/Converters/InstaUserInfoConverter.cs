using System;
using InstagramScraper.Classes.Models;
using InstagramScraper.Classes.ResponseWrappers;

namespace InstagramScraper.Converters
{
    internal class InstaUserInfoConverter : IObjectConverter<InstaUserInfo, InstaUserInfoContainerResponse>
    {
        public InstaUserInfoContainerResponse SourceObject { get; set; }

        public InstaUserInfo Convert()
        {
            if (SourceObject == null)
                throw new ArgumentNullException("SourceObject");

            var userInfo = new InstaUserInfo
            {
                Username = SourceObject.User.Username,
                FullName = SourceObject.User.FullName,
                IsPrivate = SourceObject.User.IsPrivate,
                ProfilePicUrl = SourceObject.User.ProfilePicUrl,
                IsVerified = SourceObject.User.IsVerified,
                MediaCount = SourceObject.User.Media.Count,
                FollowerCount = SourceObject.User.FollowedBy.Count,
                FollowingCount = SourceObject.User.Follow.Count,
                Biography = SourceObject.User.Biography,
                ExternalUrl = SourceObject.User.ExternalUrl,
                ExternalUrlLinkshimmed = SourceObject.User.ExternalUrlLinkshimmed,
            };
            return userInfo;
        }
    }
}