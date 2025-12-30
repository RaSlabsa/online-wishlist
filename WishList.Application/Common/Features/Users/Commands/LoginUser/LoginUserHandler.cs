using MediatR;
using Microsoft.AspNetCore.Identity;
using WishList.Application.Common.Interfaces;
using WishList.Domain.Entities;

namespace WishList.Application.Common.Features.Users.Commands.LoginUser
{
    public class LoginUserHandler(UserManager<User> userManager, IJwtProvider jwtProvider) : IRequestHandler<LoginUserCommand, string>
    {
        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                throw new Exception("Invalid email or password");
            }

            var password = await userManager.CheckPasswordAsync(user, request.Password);

            if (!password)
            {
                throw new Exception("Invalid email or password");
            }

            var token = jwtProvider.Generate(user);

            return token;
        }
    }
}
