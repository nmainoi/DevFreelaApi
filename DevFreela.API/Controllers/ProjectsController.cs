using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.API.models;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {

        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var project = _projectService.GetAll(query);
            return Ok(project);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length < 1)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = createProject }, createProject);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject){
            if (updateProject.Description.Length < 1)
            {
                return BadRequest();
            }

            return NoContent();
        }
            [HttpDelete("{id}")]
        public IActionResult Delete(int id){

            return NoContent();
        }
    }
}