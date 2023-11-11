using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.API.models;
using DevFreela.Application.Commands.CreateComment;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Query.GetAllProjects;
using DevFreela.Application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {

        //  private readonly IProjectService _projectService;
        private readonly IMediator _mediator;
        public ProjectsController(IMediator mediator)
        {
            //     _projectService = projectService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
        {
            var query = new GetAllProjectsQuery();

            var result = await this._mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProjectCommand createProjectCommand)
        {
            if (createProjectCommand.Title.Length < 1)
            {
                return BadRequest();
            }

            var id = await _mediator.Send(createProjectCommand);

            return CreatedAtAction(nameof(GetById), new { id = id }, createProjectCommand);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCommentCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length < 1)
            {
                return BadRequest();
            }

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }
    }
}