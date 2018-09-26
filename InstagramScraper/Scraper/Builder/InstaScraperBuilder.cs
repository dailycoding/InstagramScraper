using System;
using System.Net.Http;
using InstagramScraper.Classes;
using InstagramScraper.Logger;

namespace InstagramScraper.Scraper.Builder
{
    public class InstaScraperBuilder : IInstaScraperBuilder
    {
        private IRequestDelay _delay = RequestDelay.Empty();
        private HttpClient _httpClient;
        private HttpClientHandler _httpHandler = new HttpClientHandler();
        private IHttpRequestProcessor _httpRequestProcessor;
        private IInstaLogger _logger;
        private UserSessionData _user;

        private InstaScraperBuilder()
        { }

        /// <summary>
        ///     Create new Scraper instance
        /// </summary>
        /// <returns>
        ///     Scraper instance
        /// </returns>
        /// <exception cref="ArgumentNullException">User auth data must be specified</exception>
        public IInstaScraper Build()
        {
            if (_user == null)
                throw new ArgumentNullException($"User auth data must be specified");
            if (_httpClient == null)
                _httpClient = new HttpClient(_httpHandler) {BaseAddress = new Uri(Constants.WEB_URL)};

            if (_httpRequestProcessor == null)
                _httpRequestProcessor =
                    new HttpRequestProcessor(_delay, _httpClient, _httpHandler, _logger);

            var instaApi = new InstaScraper(_user, _logger, _httpRequestProcessor);
            return instaApi;
        }

        /// <summary>
        ///     Use custom logger
        /// </summary>
        /// <param name="logger">IInstaLogger implementation</param>
        /// <returns>
        ///     Scraper Builder
        /// </returns>
        public IInstaScraperBuilder UseLogger(IInstaLogger logger)
        {
            _logger = logger;
            return this;
        }

        /// <summary>
        ///     Set specific HttpClient
        /// </summary>
        /// <param name="httpClient">HttpClient</param>
        /// <returns>
        ///     Scraper Builder
        /// </returns>
        public IInstaScraperBuilder UseHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            return this;
        }

        /// <summary>
        ///     Set custom HttpClientHandler to be able to use certain features, e.g Proxy and so on
        /// </summary>
        /// <param name="handler">HttpClientHandler</param>
        /// <returns>
        ///     Scraper Builder
        /// </returns>
        public IInstaScraperBuilder UseHttpClientHandler(HttpClientHandler handler)
        {
            _httpHandler = handler;
            return this;
        }

        /// <summary>
        ///     Specify user login, password from here
        /// </summary>
        /// <param name="user">User auth data</param>
        /// <returns>
        ///     Scraper Builder
        /// </returns>
        public IInstaScraperBuilder SetUser(UserSessionData user)
        {
            _user = user;
            return this;
        }

        /// <summary>
        ///     Set delay between requests. Useful when Scraper supposed to be used for mass-bombing.
        /// </summary>
        /// <param name="delay">Timespan delay</param>
        /// <returns>
        ///     Scraper Builder
        /// </returns>
        public IInstaScraperBuilder SetRequestDelay(IRequestDelay delay)
        {
            _delay = delay;
            return this;
        }

        /// <summary>
        ///     Creates the builder.
        /// </summary>
        /// <returns></returns>
        public static IInstaScraperBuilder CreateBuilder()
        {
            return new InstaScraperBuilder();
        }
    }
}