﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestAppEver.ComputingEngine.Models;

namespace BestAppEver.ComputingEngine.Generator
{
    public class ConstructionSiteTeamGenerator : TeamGenerator
    {
        public override string GetTeamName()
        {
            return "Construction Site Team";
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
