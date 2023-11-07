using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.API.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
            private readonly OpeningTimeModel _option;
        public UsersController(IOptions<OpeningTimeModel> option)
        {
            _option = option.Value;
        }
        [HttpGet("{id}")]


        public IActionResult GetById(int id)
        {
            var mess = _option.StartAt;
            return Ok();
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {

            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }
    }
}