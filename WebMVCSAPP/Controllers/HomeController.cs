using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WebMVCSAPP.Models;

namespace WebMVCSAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LoginSAPP()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> GetCountries()
        {
            string url = "https://localhost:44382/api/Users/GetCountries";

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var countries = JsonConvert.DeserializeObject<List<CountryViewModel>>(jsonResponse);

                return Json(countries);
            }
            catch (HttpRequestException e)
            {

                throw;
            }
            
        }

        public async Task<IActionResult> GetDepStaProsByCountry(int countryId)
        {
            string url = "https://localhost:44382/api/Users/GetDepStaProsByCountry?countryId" + countryId;

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var departments = JsonConvert.DeserializeObject<List<DepStaProViewModel>>(jsonResponse);

                return Json(departments);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
