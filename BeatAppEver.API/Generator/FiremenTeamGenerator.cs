using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestAppEver.API.Models;

namespace BestAppEver.API.Generator
{
    public class FiremenTeamGenerator : TeamGenerator
    {
        public override string GetTeamName()
        {
            return "Fireman Team";
        }

        public override TeamMember GetLeader()
        {
            throw new NotImplementedException();
        }

        public override ICollection<TeamMember> GetTeamMembers(int number)
        {
            throw new NotImplementedException();
        }

        public override ICollection<Models.Task> GetTasks(int number)
        {
            throw new NotImplementedException();
        }

        public override ICollection<TeamMemberType> GetTeamTypes()
        {
            throw new NotImplementedException();
        }
    }
}
