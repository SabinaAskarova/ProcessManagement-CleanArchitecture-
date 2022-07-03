using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProcessManagementApplication.Users.Commands;
using ProcessManagementApplication.Users.DTOs;
using ProcessManagementApplication.Users.Queries;

namespace ProcessManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateUserCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDTO>>> GetAll()
        {
            var result= await _mediator.Send(new GetAllUsersQuery());
            return result;
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<UserDTO>> Get(int id)
        {
            return await _mediator.Send(new GetUserByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update([FromBody] UpdateUserCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await _mediator.Send(new DeleteUserCommand { Id = id });
        }

        //private readonly IUserRepository _userRepository;
        //public UserController(IUserRepository userRepository)
        //{
        //    _userRepository = userRepository;
        //}

        //[HttpPost]
        //public async Task<int> Add([FromBody] User user)
        //{
        //   return await _userRepository.Add(user);
        //}
        //[HttpDelete]
        //public async Task<int> Delete(int id)
        //{
        //    return await _userRepository.Delete(id);
        //}
        //[HttpGet]
        //public async Task<IEnumerable<User>> GetAll()
        //{
        //    return await _userRepository.GetAll();
        //}
        //[HttpPut]
        //public async Task<int> Update([FromBody] User user)
        //{
        //    return await _userRepository.Update(user);
        //}
    }
}
