using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.models
{
    public class CreateUserModel
    {
        public string UserName { get; set; }
        public string Password {get; set;}
    }
}