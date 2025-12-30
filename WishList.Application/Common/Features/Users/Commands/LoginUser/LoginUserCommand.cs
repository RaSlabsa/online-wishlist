using MediatR;

namespace WishList.Application.Common.Features.Users.Commands.LoginUser
{
    public record LoginUserCommand(string Email, string Password) : IRequest<string>;
}
