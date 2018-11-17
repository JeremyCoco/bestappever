using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestAppEver.ComputingEngine.Models
{
    public class TeamMember
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public TeamMemberType AssignedRole { get; set; }
        public bool IsAdmin { get; set; }
    }
}
