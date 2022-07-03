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
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserDTO> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Users.GetById(request.Id);
            return _mapper.Map<UserDTO>(result);
        }
    }
}
