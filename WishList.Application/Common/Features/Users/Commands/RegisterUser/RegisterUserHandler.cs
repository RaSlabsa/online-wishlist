using MediatR;
using Microsoft.AspNetCore.Identity;
using WishList.Application.DTOs.Users;
using WishList.Application.Mappings;
using WishList.Domain.Entities;

namespace WishList.Application.Common.Features.Users.Commands.RegisterUser
{
    public class RegisterUserHandler(UserManager<User> userManager) : IRequestHandler<RegisterUserCommand, UserDto?>
    {
        public async Task<UserDto?> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.dto.ToEntity();

            var result = await userManager.CreateAsync(user, request.dto.Password);

            if (!result.Succeeded)
            {
                var error = result.Errors.FirstOrDefault()?.Description ?? "Registration failed";
                throw new Exception(error);
            }

            return user.ToDto();
        }
    }
}
