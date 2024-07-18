using Microsoft.AspNetCore.Mvc;
using MpesaIntergration.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MpesaIntergration.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> GetToken()
        {
            var client = _clientFactory.CreateClient("mpesa");
            var authString = "khhvbjI2OD0FP2CWnMtqZ6GmYkyO2rylGj3kqFnTvmIaGEJ3 : 91CTcgoq8aKGYwgQAiibVDD8SQWoyMGrj3LoFM1AH3raiMxQXAwArj5asAhXnB6u";

            var encodedString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authString));

            var _url = "/oauth/v1/generate?grant_type=client_credentials";

            var request = new HttpRequestMessage(HttpMethod.Get, _url);

            request.Headers.Add("Authorization", $"Basic {encodedString}");

            var response = await client.SendAsync(request);

            var mpesaResponse = await response.Content.ReadAsStringAsync();

            Token tokenObject = JsonConvert.DeserializeObject<Token>(mpesaResponse);

            return tokenObject.access_token;
            
        }

        // register url

        public IActionResult RegisterURLs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}