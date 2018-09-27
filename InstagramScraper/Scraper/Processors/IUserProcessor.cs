﻿using System.Threading.Tasks;
using InstagramScraper.Classes;
using InstagramScraper.Classes.Models;

namespace InstagramScraper.Scraper.Processors
{
    public interface IUserProcessor
    {
        // Task<IResult<InstaMediaList>> GetUserMediaAsync(long username, PaginationParameters paginationParameters);
        //Task<IResult<InstaUser>> GetUserAsync(string username);
        // Task<IResult<InstaUserShortList>> SearchUsersAsync(string searchPattern);
        // Task<IResult<InstaCurrentUser>> GetCurrentUserAsync();

        // Task<IResult<InstaUserShortList>> GetUserFollowersAsync(string username,
        //     PaginationParameters paginationParameters, string searchQuery);

        // Task<IResult<InstaUserShortList>> GetUserFollowingAsync(string username,
        //     PaginationParameters paginationParameters, string searchQuery);

        // Task<IResult<InstaUserShortList>> GetCurrentUserFollowersAsync(PaginationParameters paginationParameters);
        // Task<IResult<InstaMediaList>> GetUserTagsAsync(long username, PaginationParameters paginationParameters);
        // Task<IResult<InstaFriendshipStatus>> FollowUserAsync(long userId);
        // Task<IResult<InstaFriendshipStatus>> UnFollowUserAsync(long userId);
        // Task<IResult<InstaFriendshipStatus>> BlockUserAsync(long userId);
        // Task<IResult<InstaFriendshipStatus>> UnBlockUserAsync(long userId);
        // Task<IResult<InstaFriendshipStatus>> GetFriendshipStatusAsync(long userId);
        // Task<IResult<InstaUserInfo>> GetUserInfoByIdAsync(long pk);
        Task<IResult<InstaUserInfo>> GetUserInfoByUsernameAsync(string username);
    }
}