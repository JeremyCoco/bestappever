using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BestAppEver.ComputingEngine.Models;
using BestAppEver.ComputingEngine.Helpers;
using BestAppEver.ComputingEngine.Generator;
using Newtonsoft.Json;

namespace BestAppEver.ComputingEngine.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Instanciating with base URL  
            FirebaseDatabaseHelper firebaseDB = new FirebaseDatabaseHelper("https://bestappever-7ea3a.firebaseio.com");

            // Referring to Node with name "Teams"  
            FirebaseDatabaseHelper firebaseDBTeams = firebaseDB.Node("Teams");

            KitchenTeamGenerator kitchenTeamGen = new KitchenTeamGenerator();
            Team kitchenTeam = new Team
            {
                Name = kitchenTeamGen.GetTeamName(),
                Members = new List<TeamMember>(),
                MemberTypes = kitchenTeamGen.GetTeamTypes(),
                Tasks = new List<Models.Task>()
            };

            kitchenTeam.Members.Add(kitchenTeamGen.GetLeader());
            foreach (var item in kitchenTeamGen.GetTeamMembers(19))
            {
                kitchenTeam.Members.Add(item);
            }

            FirebaseResponse getResponse = firebaseDBTeams.Get();
            
            var parsedKitchenTeam = JsonConvert.SerializeObject(kitchenTeam);

            //FirebaseResponse putResponse = firebaseDBTeams.Put(data);

            FirebaseResponse postResponse = firebaseDBTeams.Post(parsedKitchenTeam);

            //WriteLine("PATCH Request");
            //FirebaseResponse patchResponse = firebaseDBTeams
            //    // Use of NodePath to refer path lnager than a single Node  
            //    .NodePath("Team-Awesome/Members/M1")
            //    .Patch("{\"Designation\":\"CRM Consultant\"}");
            //WriteLine(patchResponse.Success);
            //WriteLine();

            //FirebaseResponse deleteResponse = firebaseDBTeams.Delete();

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
