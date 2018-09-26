using System.Net.Http;
using InstagramScraper.Classes;
using InstagramScraper.Logger;

namespace InstagramScraper.Scraper.Builder
{
    public interface IInstaScraperBuilder
    {
        /// <summary>
        ///     Create new Scraper instance
        /// </summary>
        /// <returns>Scraper instance</returns>
        IInstaScraper Build();

        /// <summary>
        ///     Use custom logger
        /// </summary>
        /// <param name="logger">IInstaLogger implementation</param>
        /// <returns>Scraper Builder</returns>
        IInstaScraperBuilder UseLogger(IInstaLogger logger);

        /// <summary>
        ///     Set specific HttpClient
        /// </summary>
        /// <param name="httpClient">HttpClient</param>
        /// <returns>Scraper Builder</returns>
        IInstaScraperBuilder UseHttpClient(HttpClient httpClient);

        /// <summary>
        ///     Set custom HttpClientHandler to be able to use certain features, e.g Proxy and so on
        /// </summary>
        /// <param name="handler">HttpClientHandler</param>
        /// <returns>Scraper Builder</returns>
        IInstaScraperBuilder UseHttpClientHandler(HttpClientHandler handler);

        /// <summary>
        ///     Specify user login, password from here
        /// </summary>
        /// <param name="user">User auth data</param>
        /// <returns>Scraper Builder</returns>
        IInstaScraperBuilder SetUser(UserSessionData user);

        /// <summary>
        ///     Set delay between requests. Useful when Scraper supposed to be used for mass-bombing.
        /// </summary>
        /// <param name="delay">Timespan delay</param>
        /// <returns>Scraper Builder</returns>
        IInstaScraperBuilder SetRequestDelay(IRequestDelay delay);
    }
}