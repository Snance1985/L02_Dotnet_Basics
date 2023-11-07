using Microsoft.AspNetCore.Mvc;

namespace L02_dotnet_basics.Controllers
{
    public class PracticeController : Controller
    {
        public PracticeController()
        {
        }

        public IActionResult Index()
        {
            ViewBag.FavoriteColor = "Pink";
            ViewBag.PenguinCount = 50;

            string[] studentNames = { "Luke", "Han", "Chewy" };
            ViewData["students"] = studentNames;
            ViewData["studentCount"] = studentNames.Length;

            return View();
        }

    }
}
