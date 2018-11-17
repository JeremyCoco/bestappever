using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeatAppEver.API.Data;
using BestAppEver.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BeatAppEver.API.Controllers
{
    [Route("Teams")]
    public class TeamAPIController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeamAPIController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("")]
        public JsonResult GetAll()
        {
            ICollection<Team> model = _context.Teams.Select(n => n).ToList();
            return Json(model);
        }

        [Route(":id")]
        public JsonResult GetById(int id)
        {
            Team model = _context.Teams.Include(n => n.Members).Include(n => n.MemberTypes).Include(n => n.Tasks).FirstOrDefault(n => n.Id == id);
            return Json(model);
        }
    }
}