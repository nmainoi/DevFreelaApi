using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.ViewModels;
using MediatR;

namespace DevFreela.Application.Query.GetProjectById
{
    public class GetProjectById : IRequest<ProjectDetailsViewModel>
    {
        public GetProjectById(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}