using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagementApplication.Users.Commands
{
    public class DeleteUserCommand : IRequest<int>
    {
        public int Id { get; set; }

    }
}
