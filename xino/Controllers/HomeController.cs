using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using xino.Models;

namespace xino.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
