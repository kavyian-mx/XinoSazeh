using Microsoft.AspNetCore.Mvc;

namespace ENDPOINTs.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class BlogController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {


            return View();
        }

        public async Task<IActionResult> Deleted()
        {


            return View();
        }
    }
}
