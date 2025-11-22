using Microsoft.AspNetCore.Mvc;

namespace ENDPOINTs.Controllers
{
    public class CallMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
