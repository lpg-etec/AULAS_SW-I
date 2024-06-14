using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class Cliente : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
    }
}
