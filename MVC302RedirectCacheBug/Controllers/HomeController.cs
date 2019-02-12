using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC302RedirectCacheBug.Models;

namespace MVC302RedirectCacheBug.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Request.Cookies.ContainsKey("ccc"))
            {
                return this.RedirectToAction("B", "Home");
            }
            else
            {
                return this.RedirectToAction("A", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult A()
        {
            if (HttpContext.Request.Cookies.ContainsKey("ccc"))
            {
                return this.RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult B()
        {
            return View();
        }
    }
}
