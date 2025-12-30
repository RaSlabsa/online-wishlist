using MediatR;
using WishList.Application.DTOs.Users;

namespace WishList.Application.Common.Features.Users.Queries.GetUserById
{
    public record GetUserByIdQuery(int Id) : IRequest<UserDto?>;
}
