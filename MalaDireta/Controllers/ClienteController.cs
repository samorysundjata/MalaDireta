using Microsoft.AspNetCore.Mvc;

namespace MalaDireta.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
