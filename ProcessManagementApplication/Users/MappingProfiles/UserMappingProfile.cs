using AutoMapper;
using ProcessManagementApplication.Users.Commands;
using ProcessManagementApplication.Users.DTOs;
using ProcessManagementCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagementApplication.Users.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserCommand, User>();
            CreateMap<UpdateUserCommand, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
