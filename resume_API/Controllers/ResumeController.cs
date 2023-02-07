using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using resume_API.Json_Nonsense;
using Resume_API_Interactor;
using resume_MODELS.API;
using resume_MODELS.DTO;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace resume_API.Controllers
{
    public class ResumeController : Controller
    {
        private HttpClient _client { get; set; }
        private Interactor _db { get; set; }
        private string url { get; set; } = "http://localhost:5000/api/resume";
        public ResumeController()
        {
            _db = new Interactor(); 
            _client = new HttpClient();
        }
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    JArray obj = ProcessJsonAsync(_client, url).Result;
        //    Console.WriteLine(obj);
        //    RootConverter converter = new RootConverter();
        //    Root model = JsonConvert.DeserializeObject<Root>(obj[0].ToString(), converter);
        //    //_db.AddResumeToDb(model);
        //    return View(model);
        //}

        #region for Api Calls
        public static async Task<JArray> ProcessJsonAsync(HttpClient client, string url)
        {
            var req = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers = {

                }
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using (var response = await client.SendAsync(req))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JArray jObject = JArray.Parse(body);
                return jObject ?? new();
            }
        }

        #endregion
    }
}
