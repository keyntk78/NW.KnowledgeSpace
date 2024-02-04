using Microsoft.AspNetCore.Mvc;

namespace NW.KnowledgeSpace.Backend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
