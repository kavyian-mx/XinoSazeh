using Microsoft.AspNetCore.Mvc;

namespace ENDPOINTs.Areas.AdminPanel.Controllers
{
    [Area("adminpanel")]
    public class AdminController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {


            return View();
        }
    }
}
