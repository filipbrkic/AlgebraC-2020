using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2021.Migrations
{
    public class Configuration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
