using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        
    public ProjectComment(string content, int idProject, int idUser) 
        {
          this.Content = content;
        this.IdProject = idProject;
        this.IdUser = idUser;
        this.CreateAt = DateTime.Now;
   
        }
                public string Content { get; private set; }
        public int IdProject { get; private set; }
        public  int IdUser { get; private set; }
        public DateTime CreateAt { get; private set; }
    }
}