using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BestAppEver.API.Models;
using BestAppEver.API.Helpers;
using BestAppEver.API.Generator;
using Newtonsoft.Json;

namespace BestAppEver.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {




            return View();
        }

        public IActionResult ManageMembers()
        {
            return View();
        }

        public IActionResult ManageMemberTypes()
        {
            return View();
        }

        public IActionResult ManageTasks()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
