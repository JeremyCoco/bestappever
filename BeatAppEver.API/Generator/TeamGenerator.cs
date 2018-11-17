using BestAppEver.ComputingEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestAppEver.ComputingEngine.Generator
{
    abstract public class TeamGenerator
    {
        abstract public TeamMember GetLeader();
        abstract public ICollection<TeamMember> GetTeamMembers(int number);
        abstract public String GetTeamName();
        abstract public ICollection<Models.Task> GetTasks(int number);
        abstract public ICollection<TeamMemberType> GetTeamTypes();
    }
}
