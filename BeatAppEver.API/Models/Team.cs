using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestAppEver.API.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<TeamMember> Members { get; set; }
        public ICollection<TeamMemberType> MemberTypes { get; set; }
        public ICollection<Models.Task> Tasks { get; set; }
    }
}
