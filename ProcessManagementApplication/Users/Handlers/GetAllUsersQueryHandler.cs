using AutoMapper;
using MediatR;
using ProcessManagementApplication.Interfaces;
using ProcessManagementApplication.Users.DTOs;
using ProcessManagementApplication.Users.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessManagementApplication.Users.Handlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<UserDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Users.GetAll();
            return _mapper.Map<List<UserDTO>>(result.ToList());
        }
    }
}
