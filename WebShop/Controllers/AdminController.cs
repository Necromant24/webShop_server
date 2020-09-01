using System;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    
    [Route("[controller]")]
    public class AdminController:Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            Console.WriteLine("in view action");
            return View();
        }

    }
}