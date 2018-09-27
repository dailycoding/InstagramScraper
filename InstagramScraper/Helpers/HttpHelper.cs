using System;
using System.Collections.Generic;
using System.Net.Http;
using InstagramScraper.Scraper;
using InstagramScraper.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramScraper.Helpers
{
    internal static class HttpHelper
    {
        public static HttpRequestMessage GetDefaultRequest(HttpMethod method, Uri uri)
        {
            var request = new HttpRequestMessage(method, uri);
            //request.Headers.Add(Constants.HEADER_ACCEPT_ENCODING, Constants.ACCEPT_ENCODING);
            request.Headers.Add(Constants.HEADER_ACCEPT_LANGUAGE, Constants.ACCEPT_LANGUAGE);
            request.Headers.Add(Constants.HEADER_HOST, Constants.HOST);
            request.Headers.Add(Constants.HEADER_ORIGN, Constants.ORIGIN);
            request.Headers.Add(Constants.HEADER_REFERER, Constants.REFERER);
            request.Headers.Add(Constants.HEADER_USER_AGENT, Constants.USER_AGENT);
            return request;
        }
    }
}