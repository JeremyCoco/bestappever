using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeatAppEver.API.Data;
using BestAppEver.API.Generator;
using BestAppEver.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeatAppEver.API.Controllers
{
    public class DataGeneratorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DataGeneratorController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KitchenTeam()
        {
            KitchenTeamGenerator kitchenTeamGen = new KitchenTeamGenerator();
            Team kitchenTeam = new Team
            {
                Name = kitchenTeamGen.GetTeamName(),
                Members = new List<TeamMember>(),
                MemberTypes = kitchenTeamGen.GetTeamTypes(),
                Tasks = new List<BestAppEver.API.Models.Task>()
            };

            kitchenTeam.Members.Add(kitchenTeamGen.GetLeader());
            foreach (var item in kitchenTeamGen.GetTeamMembers(19))
            {
                kitchenTeam.Members.Add(item);
            }

            _context.Teams.Add(kitchenTeam);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ConstructionSiteTeam()
        {

            ConstructionSiteTeamGenerator cSiteTeamGen = new ConstructionSiteTeamGenerator();
            Team cSiteTeam = new Team
            {
                Name = cSiteTeamGen.GetTeamName(),
                Members = new List<TeamMember>(),
                MemberTypes = cSiteTeamGen.GetTeamTypes(),
                Tasks = new List<BestAppEver.API.Models.Task>()
            };

            cSiteTeam.Members.Add(cSiteTeamGen.GetLeader());
            foreach (var item in cSiteTeamGen.GetTeamMembers(19))
            {
                cSiteTeam.Members.Add(item);
            }

            _context.Teams.Add(cSiteTeam);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult TasksForKitchen(int number)
        {
            Random rand = new Random();

            Team model = _context.Teams.Include(n => n.Members).ThenInclude(n => n.AssignedRole).Include(n => n.MemberTypes).FirstOrDefault(n => n.Id == 1);

            for(int i = 0; i < number; i++)
            {
                var modelToAdd = new BestAppEver.API.Models.Task
                {
                    DificultyGradeByWorker = rand.Next(0, 100),
                    DificultyGradeByLeader = rand.Next(0, 100),

                    TimeEstimatedByWorker = rand.Next(0, 100),
                    ActualTimePassed = rand.Next(0, 100)
                };

                if (rand.Next(0, 100) > 90)
                {
                    modelToAdd.ResultGradeByLeader = rand.Next(0, 50);
                    modelToAdd.ResultGradeByWorker = rand.Next(0, 50);
                }

                modelToAdd.username = model.Members.OrderBy(n => Guid.NewGuid()).Select(n => n.Email).FirstOrDefault();

                model.Tasks.Add(modelToAdd);
            }

            _context.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}