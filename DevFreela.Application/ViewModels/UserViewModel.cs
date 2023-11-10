using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {

        public UserViewModel(string fullName, string email, DateTime birthDate, DateTime createdAt)
        {
            this.FullName = fullName;
            this.Email = email;
            this.BirthDate = birthDate;
            this.CreatedAt = createdAt;

        }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        public DateTime CreatedAt { get; private set; }
    }
}