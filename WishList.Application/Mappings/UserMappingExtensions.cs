using WishList.Application.DTOs.Users;
using WishList.Application.DTOs.Friendships;
using WishList.Domain.Entities;

namespace WishList.Application.Mappings
{
    public static class UserMappingExtensions
    {
        public static UserDto? ToDto(this User? entity)
        {
            if (entity == null) return null;

            return new UserDto
            {
                UserId = entity.UserId,
                UserName = entity.UserName,
                Email = entity.Email,
                ReceivedFriendRequest = entity.ReceivedFriendRequest
                    .Select(f => f.ToDto())
                    .OfType<FriendshipDto>()
                    .ToList()
                    
            };
        }
        public static User ToEntity(this UserCreateDto dto)
        {
            return new User
            {
                UserName = dto.UserName,
                Password = string.Empty,
                Email = dto.Email
            };
        }
    }
}
