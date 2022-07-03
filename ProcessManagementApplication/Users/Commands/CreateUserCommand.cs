using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagementApplication.Users.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Name { get; set; }
        
    }
}
