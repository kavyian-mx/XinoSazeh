using Microsoft.AspNetCore.Mvc;

namespace ENDPOINTs.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CvController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> ListCheck()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> NotChecket()
        {


            return View();
        }

    }
}
