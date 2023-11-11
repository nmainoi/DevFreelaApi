using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll(string query);

        ProjectDetailsViewModel GetById(int id);

        void Update(UpdateProjectInputModel inputModel);

        void Delete(int id);

        void Start(int id);

        void Finish(int id);

        void CreateComment(CreateCommentInputModel inputModel);
    }
}