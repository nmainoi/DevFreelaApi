using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.Enums;

namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {

        public Project(string title, string description,int idClient, int idFreelancer, decimal totalCost) 
        {
            this.Title = title;
            this.Description = description;
            this.IdClient = idClient;
            this.IdFreelancer = idFreelancer;
            
            this.Status = ProjectStatusEnum.Created;
            this.TotalCost = totalCost;
            
            this.CreatedAt = DateTime.Now;
            this.Comments = new();
   
        }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public int IdClient { get; private set; }

        public int IdFreelancer { get; private set; }
        public decimal TotalCost {get; private set;}

        public DateTime CreatedAt  { get; private set; }

        public DateTime? StartedAt {get; private set;}

        public DateTime? FinishedAt { get; private set; }

        public ProjectStatusEnum Status {get; private set;}

        public List<ProjectComment> Comments {get; private set;}

        public void Cancel(){
            if(Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.Created)
            Status = ProjectStatusEnum.Cancelled;
        }

        public void Finish(){
            if(Status == ProjectStatusEnum.InProgress){

            Status = ProjectStatusEnum.Finished;
            FinishedAt = DateTime.Now;
            }
        }

        public void Start(){
            if(Status == ProjectStatusEnum.Created){

            Status = ProjectStatusEnum.InProgress;
            StartedAt = DateTime.Now;
            }
        }

        public void Update( string title, string description, decimal totalCost){
            this.Title = title;
            this.Description = description;
            this.TotalCost = totalCost;
        }
    }
}