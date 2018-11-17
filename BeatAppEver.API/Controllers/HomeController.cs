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
using BeatAppEver.API.Data;
using Microsoft.EntityFrameworkCore;

namespace BestAppEver.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            ICollection<Team> model = _context.Teams.Include(n => n.Members).Include(n => n.MemberTypes).Include(n => n.Tasks).Select(n => n).ToList();

            return View(model);
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
