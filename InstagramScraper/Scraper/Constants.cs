using System;

namespace InstagramScraper.Scraper
{
    internal static class Constants
    {
        public const string WEB_URL = "https://www.instagram.com";
        public const string HEADER_ACCEPT_ENCODING = "Accept-Encoding";
        public const string HEADER_ACCEPT_LANGUAGE = "Accept-Language";
        public const string ACCEPT_LANGUAGE = "en-US,en;q=0.5";
        public const string HEADER_HOST = "Host";
        public const string HOST = "www.instagram.com";
        public const string HEADER_ORIGN = "Origin";
        public const string ORIGIN = "https://www.instagram.com";
        public const string HEADER_REFERER = "Referer";
        public const string REFERER = "https://www.instagram.com/";
        public const string HEADER_USER_AGENT = "User-Agent";
        public const string USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 " +
                                    "(KHTML, like Gecko) Chrome/48.0.2564.103 Safari/537.36";

        public const string GET_USER_INFO_BY_USERNAME = "/{0}/";
    }
}
