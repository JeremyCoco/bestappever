using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestAppEver.API.Models;

namespace BestAppEver.API.Generator
{
    public class ConstructionSiteTeamGenerator : TeamGenerator
    {
        public override string GetTeamName()
        {
            return "Construction Site Team";
        }

        public override TeamMember GetLeader()
        {
            return new TeamMember
            {
                Firstname = "Dyan",
                Lastname = "Dowd",
                Email = "dyan.dowd@fakeProductionSite.com.pl",
                AssignedRole = null,
                IsAdmin = true,
                AvatarPath = "https://robohash.org/Dyan"
            };
        }

        public override ICollection<TeamMember> GetTeamMembers(int number)
        {
            var possibleFirstnames = new List<string>() { "Erinn", "Charleen", "Estefana", "Oscar", "Ezequiel", "Jesenia", "Moira", "Connie", "Sarina", "Lorraine", "Frederica", "Aracelis", "Audry", "Patti", "Cierra", "Lowell", "Britany", "Alverta", "Nga", "Williemae" };
            var possibleLastnames = new List<string>() { "Barfield", "Colangelo", "Mae", "Moua", "Wadman", "Rumph", "Yardley", "Furrow", "Bronk", "Sarcone", "Michelin", "Troxel", "Dileo", "Kogan", "Ganley", "Shaughnessy", "Washinton", "Bob", "Chea", "Mcnelly" };

            ICollection<TeamMember> members = new List<TeamMember>();
            Random rand = new Random();

            for (int i = 0; i < number; i++)
            {
                var fname = possibleFirstnames.ElementAt(rand.Next(0, possibleFirstnames.Count - 1));
                var lname = possibleLastnames.ElementAt(rand.Next(0, possibleLastnames.Count - 1));

                members.Add(new TeamMember
                {
                    Firstname = fname,
                    Lastname = lname,
                    Email = CreateEmail(fname, lname),
                    AssignedRole = GetTeamTypes().ElementAt(rand.Next(0, GetTeamTypes().Count - 1)),
                    IsAdmin = false,
                    AvatarPath = "https://robohash.org/" + fname
                });
            }

            return members;
        }

        public override ICollection<Models.Task> GetTasks(int number)
        {
            throw new NotImplementedException();
        }

        public override ICollection<TeamMemberType> GetTeamTypes()
        {
            return new List<TeamMemberType>
            {
                new TeamMemberType{
                    Name = "Construction Architekt",
                    Description = "Architekt przedsięwzięcia budowlanego"
                },
                new TeamMemberType{
                    Name = "Worker with shovel",
                    Description = "Operator łopaty"
                },
                new TeamMemberType{
                    Name = "Worker with elektro hammer",
                    Description = "Operator elektrycznego młota udarowego"
                },
                new TeamMemberType{
                    Name = "Floor tester",
                    Description = "Tester powierzchni płaskich"
                },
                new TeamMemberType{
                    Name = "Cleaner",
                    Description = "sprzątacz samodzielny"
                },
                new TeamMemberType{
                    Name = "Water springer",
                    Description = "SPryskiwacz wody na cemencie"
                }
            };
        }

        private string CreateEmail(string firstname, string lastname, string domain = "fakekitchen")
        {
            return $"{firstname.ToLower()}.{lastname.ToLower()}@{domain}.com.pl";
        }
    }
}
