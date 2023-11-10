using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly string _connectionString;
        private readonly DevFreelaDbContext _dbContext;
        public SkillService(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }
        public List<SkillViewModel> GetAll()
        {
            // dapper
            // using (var sqlconnection = new SqlConnection(_connectionString)){
            //     sqlconnection.Open();
            //     var script = "select Id, Description from Skills";
            //     return sqlconnection.Query<SkillViewModel>(script).ToList();
            // }
            var Skill = _dbContext.Skills;

            var skillsViewModel = Skill.Select( s => new SkillViewModel(s.Id,s.Description,s.CreatedAt)).ToList();
            return skillsViewModel;
        }
    }
}