using WishList.Application.DTOs.Friendships;
using WishList.Domain.Entities;

namespace WishList.Application.Mappings
{
    public static class FriendshipMappingExtensions
    {
        public static FriendshipDto? ToDto(this Friendship? entity)
        {
            if (entity == null) return null;

            return new FriendshipDto
            {
                FriendshipId = entity.FriendshipId,
                ReceiverId = entity.ReceiverId,
                RequesterId = entity.RequesterId,
                Status = entity.Status
            };
        }
        public static Friendship ToEntity(this FriendshipCreateDto dto)
        {
            return new Friendship
            {
                ReceiverId = dto.ReceiverId
            };
        }
    }
}
