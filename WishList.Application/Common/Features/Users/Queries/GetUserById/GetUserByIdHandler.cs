using MediatR;
using WishList.Application.Common.Interfaces.Repositories;
using WishList.Application.DTOs.Users;
using WishList.Domain.Entities;
using WishList.Application.Mappings;

namespace WishList.Application.Common.Features.Users.Queries.GetUserById
{
    public class GetUserByIdHandler(IGenericRepository<User> repository) : IRequestHandler<GetUserByIdQuery, UserDto?> 
    {
        public async Task<UserDto?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);

            if (entity == null)
            {
                return null;
            }

            return entity.ToDto();
        }
    }
}
