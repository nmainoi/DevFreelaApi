using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project> {
                new("P1","DESCRIPTION",1,1,1000),
                new("P2","DESCRIPTION",1,1,1000),
                new("P3","DESCRIPTION",1,1,1000)
            };

            Users = new List<User>{
                new("Maino","maino@maino.com", new DateTime(2000,1,7)),
                new("Mainoi","mainoi@maino.com", new DateTime(2000,1,7)),
                new("Mani","mani@maino.com", new DateTime(2000,1,7))

            };

            Skills = new List<Skill>{
                new("C#"),
                new(".net core")
            };
        }

        public List<Project> Projects { get; private set; }
        public List<User> Users { get; private set; }
        public List<Skill> Skills  { get; private set; }
    }
}