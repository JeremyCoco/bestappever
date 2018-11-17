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
    [Route("[controller]")]
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
            return Json(model);
        }

        [HttpGet]
        [Route("one/{id}")]
        public IActionResult GetById(int id)
        {
            Team model = _context.Teams.Include(n => n.Members).ThenInclude(n => n.AssignedRole).Include(n => n.MemberTypes).Include(n => n.Tasks).FirstOrDefault(n => n.Id == id);
            return Json(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}