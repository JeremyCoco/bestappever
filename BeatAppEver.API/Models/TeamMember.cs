using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestAppEver.API.Models
{
    public class TeamMember
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string AvatarPath { get; set; }

        public TeamMemberType AssignedRole { get; set; }
        public bool IsAdmin { get; set; }
    }
}
