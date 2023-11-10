using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        
    public ProjectDetailsViewModel(int id, string description, string title, decimal totalCost, DateTime? startedAt, DateTime? finishedAt) 
        {
          this.Id = id;
            this.Description = description;
            this.Title = title;
            this.TotalCost = totalCost;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
        }
                public int Id { get; private set; }
        public string Title { get; private set; }   
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }    
    }
}