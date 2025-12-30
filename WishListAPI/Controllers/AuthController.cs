using Microsoft.AspNetCore.Mvc;
using WishList.Application.DTOs.Users;
using MediatR;
using WishList.Application.Common.Features.Users.Commands.RegisterUser;
using WishList.Application.Common.Features.Users.Commands.LoginUser;

namespace WishList.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserCreateDto dto)
        {
            var result = await mediator.Send(new RegisterUserCommand(dto));

            return Ok(result);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
        {
            var token = await mediator.Send(command);

            return Ok(new { Token = token });
        }
    }
}
