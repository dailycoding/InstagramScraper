using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using InstagramScraper;
using InstagramScraper.Classes;
using InstagramScraper.Logger;
using InstagramScraper.Scraper;
using InstagramScraper.Scraper.Builder;
using InstagramScraper.Examples.Samples;

namespace InstagramScraper.Examples
{
    class Program
    {
        /// <summary>
        /// Scraper instance
        /// </summary>
        private static IInstaScraper _instaScraper;

        static void Main(string[] args)
        {
            var result = Task.Run(MainAsync).GetAwaiter().GetResult();
            if (result)
                return;
            Console.Read();
        }

        public static async Task<bool> MainAsync()
        {
            try
            {
                Console.WriteLine("Starting demo of InstagramScraper project");

                var delay = RequestDelay.FromSeconds(2, 2);
                // create new InstaApi instance using Builder
                _instaScraper = InstaScraperBuilder.CreateBuilder()
                    .UseLogger(new DebugLogger(LogLevel.Exceptions)) // use logger for requests and debug messages
                    .SetRequestDelay(delay)
                    .Build();

                Console.WriteLine("Press 1 to start basic demo samples");

                // var samplesMap = new Dictionary<int, IDemoSample>
                // {
                //     [(int)ConsoleKey.D1] = new UserInfo(_instaScraper),
                // };
                // var key = Console.Read();
                // Console.WriteLine(Environment.NewLine);
                // if (samplesMap.ContainsKey(key))
                //     await samplesMap[key].DoShow();
                await new UserInfo(_instaScraper).DoShow();
                Console.WriteLine("Done. Press esc key to exit...");

                // return key == (int)ConsoleKey.Escape;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                // perform that if user needs to logged out
                // var logoutResult = Task.Run(() => _instaApi.LogoutAsync()).GetAwaiter().GetResult();
                // if (logoutResult.Succeeded) Console.WriteLine("Logout succeed");
            }
            return false;
        }
    }
}
