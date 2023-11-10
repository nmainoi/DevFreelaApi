using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.Application.Services.Implementations
{
    public class UsersService : IUsersService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UsersService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);
            var userView = new UserViewModel(user.FullName, user.Email, user.BirthDate, user.CreatedAt);
            return userView;
        }
    }
}