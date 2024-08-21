using DataAccessSAPP.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace WebMVCSAPP.Controllers
{
    public class AnimalsController : Controller
    {
        public IActionResult Profiles()
        {
            return View();
        }

        public async Task<IActionResult> GetAnimalTypes()
        {
            string url = "https://localhost:44382/api/Animals/GetAnimalTypes";

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var animalTypes = JsonConvert.DeserializeObject<List<AnimalType>>(jsonResponse);

                return Json(animalTypes);
            }
            catch (HttpRequestException e)
            {

                throw;
            }
        }

        public async Task<IActionResult> GetRazasByAnimalType(int animalTypeId)
        {
            string url = "https://localhost:44382/api/Animals/GetRazasByAnimalType?animalTypeId=" + animalTypeId;

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();

                var razas = JsonConvert.DeserializeObject<List<AnimalType>>(jsonResponse);

                return Json(razas);
            }
            catch (HttpRequestException e)
            {

                throw;
            }
        }
    }
}
