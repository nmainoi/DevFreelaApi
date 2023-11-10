using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class SkillViewModel
    {
        
    public SkillViewModel(int id, string description, DateTime createdAt) 
        {
          this.Id = id;
          this.Description = description;
        this.CreatedAt = createdAt;
   
        }
                public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}