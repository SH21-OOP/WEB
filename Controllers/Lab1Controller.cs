using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB.Controllers
{
    public class Lab1Controller : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Macarena()
        {
            return View();
        }

        public IActionResult SomebodyToLove()
        {
            return View();
        }

        [HttpGet()]
        public IActionResult Echo([FromQuery(Name = "echo")] string echo)
        {
            ViewBag.EchoData = echo;
            return View();
        }
    }
}
