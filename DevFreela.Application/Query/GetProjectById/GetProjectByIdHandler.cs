using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Query.GetProjectById
{
    public class GetProjectByIdHandler : IRequestHandler<GetProjectById, ProjectDetailsViewModel>
    {
        private readonly DevFreelaDbContext devFreelaDbContext;

        public GetProjectByIdHandler(DevFreelaDbContext context)
        {
            devFreelaDbContext = context;
        }

        public async Task<ProjectDetailsViewModel> Handle(GetProjectById request, CancellationToken cancellationToken)
        {
              var project = await devFreelaDbContext.Projects
                .Include(p => p.Client)
                .Include(p => p.FreeLancer)
                .SingleOrDefaultAsync(p => p.Id == request.Id);

            if (project == null) return null;

            var projectDetailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.TotalCost,
                project.StartedAt,
                project.FinishedAt,
                project.Client.FullName,
                project.FreeLancer.FullName
                );

            return projectDetailsViewModel;
        }
    }
}