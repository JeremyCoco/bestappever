using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeatAppEver.API.Data;
using BestAppEver.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BeatAppEver.API.Controllers
{
    [Route("[controller]/[action]")]
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeamsController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAll()
        {
            ICollection<Team> model = _context.Teams.Select(n => n).ToList();
            return View(model);
        }

        [HttpGet]
        [Route("one/{id}")]
        public IActionResult GetByIdAsync(int id)
        {
            Team model = _context.Teams.Include(n => n.Members).Include(n => n.MemberTypes).Include(n => n.Tasks).FirstOrDefault(n => n.Id == id);
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}