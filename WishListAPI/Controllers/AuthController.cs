using Microsoft.AspNetCore.Mvc;
using WishList.Application.DTOs.Users;
using MediatR;
using WishList.Application.Common.Features.Users.Commands.RegisterUser;

namespace WishList.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController(IMediator mediator) : Controller
    {
        [HttpPost]
        [Route("/register")]
        public async Task<IActionResult> Register([FromBody] UserCreateDto dto)
        {
            var result = await mediator.Send(new RegisterUserCommand(dto));

            return Ok(result);
        }
    }
}
