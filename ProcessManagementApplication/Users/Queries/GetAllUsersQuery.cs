using MediatR;
using ProcessManagementApplication.Users.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagementApplication.Users.Queries
{
    public class GetAllUsersQuery : IRequest<List<UserDTO>>
    {
    }
}
