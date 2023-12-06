using Microsoft.AspNetCore.Mvc;
using RedoMusic.Persistence;

namespace RedoMusic.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Configurations.GetString("ConnectionStrings:PostgreSQL");
            return View();
        }
    }
}
