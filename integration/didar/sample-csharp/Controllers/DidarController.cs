
using Microsoft.AspNetCore.Mvc;
using Sample.Didar.Configuration;
using Sample.Didar.Model;

namespace Azm.Daftareshoma.Didar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DidarController : Controller
    {

        private readonly DidarSetting _didarSetting;
        public DidarController(DidarSetting didarSetting)
        {

            _didarSetting = didarSetting;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> SendCall([FromBody] WebhookMessage webhookMessage)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{_didarSetting.Url}api/calllog/insert?apikey={_didarSetting.ApiKey}&number={webhookMessage.CallerNumber}";

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); 

                    string responseBody = await response.Content.ReadAsStringAsync();
                    return Ok(responseBody);
                }
                catch (HttpRequestException e)
                {
                    throw new Exception($"Request error: {e.Message}");
                }
            }

        }
    }

}
