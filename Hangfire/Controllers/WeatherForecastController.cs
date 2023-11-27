using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace HangfireProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            BackgroundJob.Enqueue(() => SendMessage("amr@outlook.com"));

            //Console.WriteLine(DateTime.Now);
            //BackgroundJob.Schedule(() => SendMessage("elhelaly@outlook.com"), TimeSpan.FromMinutes(1));

            // RecurringJob.AddOrUpdate(() => SendMessage("elhelaly@outlook.com"), Cron.Minutely);

            return Ok();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public void SendMessage(string email)
        {
            Console.WriteLine($"Email sent at {DateTime.Now}");
        }
    }
}