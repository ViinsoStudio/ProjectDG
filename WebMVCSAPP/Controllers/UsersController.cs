using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebMVCSAPP.Models;

namespace WebMVCSAPP.Controllers
{
    public class UsersController : Controller
    {
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
            string url = "https://localhost:44382/api/Users/GetDepStaProsByCountry?countryId=" + countryId;

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

        public async Task<IActionResult> GetCitMunsByDepStaPro(int depStaProId)
        {
            string url = "https://localhost:44382/api/Users/GetCitMunsByDepStaPro?depStaProId=" + depStaProId;

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var citiesMuns = JsonConvert.DeserializeObject<List<DepStaProViewModel>>(jsonResponse);

                return Json(citiesMuns);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IActionResult> GetDocumentTypes()
        {
            string url = "https://localhost:44382/api/Users/GetDocumentTypes";

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var documentTypes = JsonConvert.DeserializeObject<List<DepStaProViewModel>>(jsonResponse);

                return Json(documentTypes);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IActionResult> UserRegister([FromBody] UserViewModel dataUser)
        {
            string url = "https://localhost:44382/api/Users/UserRegister";

            using HttpClient client = new HttpClient();

            try
            {
                string json = JsonConvert.SerializeObject(dataUser);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

                string result = await response.Content.ReadAsStringAsync();

                return Json(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
