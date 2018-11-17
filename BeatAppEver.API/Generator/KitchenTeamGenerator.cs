using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestAppEver.API.Models;

namespace BestAppEver.API.Generator
{
    public class KitchenTeamGenerator : TeamGenerator
    {
        public override string GetTeamName()
        {
            return "Kitchen Team";
        }

        public override TeamMember GetLeader()
        {
            return new TeamMember
            {
                Firstname = "Dyan",
                Lastname = "Dowd",
                Email = "dyan.dowd@fakekitchen.com.pl",
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
                    AssignedRole = GetTeamTypes().ElementAt(rand.Next(0, GetTeamTypes().Count-1)),
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
                    Name = "Chef de cuisine",
                    Description = "szef kuchni"
                },
                new TeamMemberType{
                    Name = "Sous-chef de cuisine",
                    Description = "zastępca szefa kuchni"
                },
                new TeamMemberType{
                    Name = "Chef de partie",
                    Description = "kucharz zespołu"
                },
                new TeamMemberType{
                    Name = "Cuisinier",
                    Description = "kucharz"
                },
                new TeamMemberType{
                    Name = "Commis",
                    Description = "młodszy kucharz"
                },
                new TeamMemberType{
                    Name = "Apprenti(e)",
                    Description = "praktykant"
                },
                new TeamMemberType{
                    Name = "Plonguer",
                    Description = "pomywacz"
                },
                new TeamMemberType{
                    Name = "Saucier",
                    Description = "przygotowuje sosy oraz dania mięsne"
                },
                new TeamMemberType{
                    Name = "Rótisseur",
                    Description = "zajmuje się pieczeniem, grillowaniem oraz smażeniem"
                },
                new TeamMemberType{
                    Name = "Poissonnier",
                    Description = "kucharz rybny"
                },
                new TeamMemberType{
                    Name = "Entremetier",
                    Description = "do jego zadań należy przygotowanie zup"
                },
                new TeamMemberType{
                    Name = "Garde-manger",
                    Description = "odpowiedzialny on jest za zimną kuchnię (przekąski i sałatki)"
                },
                new TeamMemberType{
                    Name = "Tornat",
                    Description = "jest to człowiek od wszystkiego"
                },
                new TeamMemberType{
                    Name = "Patissier",
                    Description = "odpowiedzialny jest za desery"
                },
                new TeamMemberType{
                    Name = "Boulanger",
                    Description = "piekarz"
                }
            };
        }

        private string CreateEmail(string firstname, string lastname, string domain = "fakekitchen")
        {
            return $"{firstname.ToLower()}.{lastname.ToLower()}@{domain}.com.pl";
        }
    }
}
