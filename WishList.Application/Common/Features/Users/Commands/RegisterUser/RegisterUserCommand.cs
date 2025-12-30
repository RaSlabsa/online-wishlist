using MediatR;
using WishList.Application.DTOs.Users;

namespace WishList.Application.Common.Features.Users.Commands.RegisterUser
{
    public record RegisterUserCommand(UserCreateDto dto) : IRequest<UserDto>;
}
