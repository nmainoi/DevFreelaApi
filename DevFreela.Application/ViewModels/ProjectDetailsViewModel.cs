using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        
    public ProjectDetailsViewModel(int id, string description, string title, decimal totalCost, DateTime? startedAt, DateTime? finishedAt, string clientFullname, string freeLancerFullname) 
        {
          this.Id = id;
            this.Description = description;
            this.Title = title;
            this.TotalCost = totalCost;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.ClientFullname = clientFullname;
            this.FreeLancerFullname = freeLancerFullname;
        }
                public int Id { get; private set; }
        public string Title { get; private set; }   
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }   

        public string ClientFullname { get; private set; }
        public string FreeLancerFullname { get; private set; } 
    }
}