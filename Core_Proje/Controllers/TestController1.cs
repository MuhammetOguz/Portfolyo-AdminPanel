using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
