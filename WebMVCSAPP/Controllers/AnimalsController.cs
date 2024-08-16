using Microsoft.AspNetCore.Mvc;

namespace WebMVCSAPP.Controllers
{
    public class AnimalsController : Controller
    {
        public IActionResult Profiles()
        {
            return View();
        }
    }
}
