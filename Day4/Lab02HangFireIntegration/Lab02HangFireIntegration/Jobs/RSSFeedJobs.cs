using System.ServiceModel.Syndication;
using System.Text.Json;
using System.Xml;

namespace Lab02HangFireIntegration.Jobs
{
    public class RSSFeedJobs
    {

        public async Task PullRssAsync(string rssFeedUrl, string jsonFilePath)
        {
            using var httpClient = new HttpClient();
            var rssContent = await httpClient.GetStringAsync(rssFeedUrl);

            using var xmlReader = XmlReader.Create(new StringReader(rssContent));
            var feed = SyndicationFeed.Load(xmlReader);

            var rssItemUrls = feed.Items
                .Select(item => item.Links.FirstOrDefault()?.Uri.AbsoluteUri)
                .Where(url => !string.IsNullOrEmpty(url))
                .ToList();

            var json = JsonSerializer.Serialize(rssItemUrls);
            await File.WriteAllTextAsync(jsonFilePath, json);
        }

        public async Task SyncHtmlFilesAsync(string jsonFilePath, string outputDirectory, int initialDelaySeconds = 5)
        {
            if (!File.Exists(jsonFilePath)) throw new FileNotFoundException("RSS JSON file not found.");

            var rssItemUrls = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(jsonFilePath));
            if (rssItemUrls == null || rssItemUrls.Count == 0) throw new Exception("No RSS URLs found.");

            Directory.CreateDirectory(outputDirectory);

            int delay = initialDelaySeconds;
            foreach (var url in rssItemUrls)
            {
                var stub = Path.GetFileName(new Uri(url).AbsolutePath).TrimEnd('/') + ".html";
                var htmlFile = Path.Combine(outputDirectory, stub);

                // Optionally: add delay between downloads
                await Task.Delay(TimeSpan.FromSeconds(delay));
                await DownloadFileFromUrl(url, htmlFile);

                delay += initialDelaySeconds;
            }
        }

        private async Task DownloadFileFromUrl(string url, string filePath)
        {
            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            await using var stream = await response.Content.ReadAsStreamAsync();
            await using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            await stream.CopyToAsync(fileStream);
        }
    }


}
