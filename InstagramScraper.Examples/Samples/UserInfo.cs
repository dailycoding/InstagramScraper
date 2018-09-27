using System;
using System.Linq;
using System.Threading.Tasks;
using InstagramScraper.Scraper;
using InstagramScraper.Classes;

namespace InstagramScraper.Examples.Samples
{
    internal class UserInfo : IDemoSample
    {
        private readonly IInstaScraper _instaScraper;

        public UserInfo(IInstaScraper instaScraper)
        {
            _instaScraper = instaScraper;
        }

        public async Task DoShow()
        {
            string userId = "disney";

            var user = await _instaScraper.GetUserInfoByUsernameAsync(userId);

            Console.WriteLine($"User details for '{userId}'");
            Console.WriteLine($"Fullname: {user.Value.FullName}");
            Console.WriteLine($"Profile Picture: {user.Value.ProfilePicUrl}");
            Console.WriteLine($"Followers: {user.Value.FollowerCount}");
            Console.WriteLine($"Followings: {user.Value.FollowingCount}");
            Console.WriteLine($"External Link: {user.Value.ExternalUrl}");
        }
    }
}