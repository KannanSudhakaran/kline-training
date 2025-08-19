using Hangfire;
using Lab02HangFireIntegration.Jobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab02HangFireIntegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private IBackgroundJobClient _jobClient;

        public JobsController(IBackgroundJobClient jobClient)
        { 
        
            _jobClient = jobClient;
        }

        [HttpGet("hello-job")]
        public IActionResult HelloJob() {

            // var job = new PrintingJobs();
            // _jobClient.Enqueue(() => job.HelloWorld());

           _jobClient.Enqueue<PrintingJobs>(p=>p.HelloWorld("Hello World..This is heavy task..going..on"));

            return Ok("Hello job started");
        }

        [HttpGet("delay")]
        public IActionResult ScheduleJob()
        {
            _jobClient.Schedule<PrintingJobs>(p => p.HelloWorld("This is delayed for 50 seconds"), TimeSpan.FromSeconds(50));

            return Ok("delayed job");
        }

        [HttpGet("recurring")]
        public IActionResult CronJob() {

            RecurringJob.AddOrUpdate<PrintingJobs>("job1-recurring", 
                (p => p.HelloWorld("cron job")), Cron.Minutely);

            return Ok("cron job started");
        
        }

        [HttpGet("downloadRSS")]
        public IActionResult DownloadRssToJSONFile()
        {
            string jsonFile = @"C:\LiveSessionKoenig\KlineDotnetCustom\kline-training\Day4\RSS\data.json";
            _jobClient.Enqueue<RSSFeedJobs>(p => p.PullRssAsync("https://feeds.bbci.co.uk/news/rss.xml", jsonFile));

            return Ok("Dolwad of rss started..");
        }

        [HttpGet("downloadHtml")]
        public IActionResult DownloadHtmlFiles()
        {
            string jsonFile = @"C:\LiveSessionKoenig\KlineDotnetCustom\kline-training\Day4\RSS\data.json";
            string folderPath = @"C:\LiveSessionKoenig\KlineDotnetCustom\kline-training\Day4\RSS\download";
            _jobClient.Enqueue<RSSFeedJobs>(p => p.SyncHtmlFilesAsync(jsonFile, folderPath, 5));

 
            return Ok("html  job started");
        }
    }
}
