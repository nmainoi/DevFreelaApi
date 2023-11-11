using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Commands.CreateProject
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
    {
        private readonly DevFreelaDbContext _dbContext;

        public CreateProjectCommandHandler(DevFreelaDbContext context)
        {
            _dbContext = context;
        }

        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
        //   var comment = new ProjectComment(request.Content, request.IdProject, request.IdUser);

        //    await _dbContext.ProjectComments.AddAsync(comment);
        //    await _dbContext.SaveChangesAsync();

         var project = new Project(request.Title, request.Description, request.IdClient, request.IdFreelance, request.TotalCost);

           await _dbContext.Projects.AddAsync(project);

           await _dbContext.SaveChangesAsync();
           return project.Id;
        }
    }
}