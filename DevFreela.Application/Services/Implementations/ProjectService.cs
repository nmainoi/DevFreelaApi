using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService 
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
 

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            

        }


        public List<ProjectViewModel> GetAll(string query)
        {
            var projects = _dbContext.Projects;

            var projectsViewModel = projects.Select( p => new ProjectViewModel(p.Title, p.CreatedAt) ).ToList();

            return projectsViewModel;
        }

        public ProjectDetailsViewModel GetById(int id)
        {
             var project = _dbContext.Projects
             .Include( p => p.Client)
             .Include( p => p.FreeLancer)
             .SingleOrDefault( p => p.Id == id);

            if(project == null) return null;
             var projectsViewModel = new ProjectDetailsViewModel(
                    project.Id,
                    project.Description,
                    project.Title,
                    project.TotalCost,
                    project.StartedAt,
                    project.FinishedAt,
                    project.Client.FullName,
                    project.FreeLancer.FullName

             );

             return projectsViewModel;
        }
        public void Delete(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault( p => p.Id == id);

            project?.Cancel();
           _dbContext.SaveChanges();

        }


        public void Finish(int id)
        {
             var project = _dbContext.Projects.SingleOrDefault( p => p.Id == id);

            project?.Finish();
           _dbContext.SaveChanges();

        }

        public void Start(int id)
        {
             var project = _dbContext.Projects.SingleOrDefault( p => p.Id == id);

            project?.Start();
           _dbContext.SaveChanges();

        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            var project = _dbContext.Projects.SingleOrDefault( p => p.Id == inputModel.Id);

            project?.Update(inputModel.Title,inputModel.Description,inputModel.TotalCost);
           _dbContext.SaveChanges();

        }
    }
}