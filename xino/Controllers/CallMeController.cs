using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ENDPOINTs.Models.DTOs;
using xino.SERVICE.Service;
using xino.DEL.Entity;

namespace ENDPOINTs.Controllers
{
    public class CallMeController : Controller
    {


       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


    }
}