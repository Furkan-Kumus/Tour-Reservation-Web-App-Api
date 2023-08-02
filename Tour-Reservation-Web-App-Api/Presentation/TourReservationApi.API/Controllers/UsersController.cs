using TourReservationApi .Application.Features.Commands.AppUser.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourReservationApi.Application.Features.Commands.AppUser.CreateUser;

namespace TourReservationApi.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }
        [HttpPost]

        public async Task<ActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
            {
        LoginUserCommandResponse response = await _mediator.Send(loginUserCommandRequest);
            return Ok(response);
            }
    }
}
