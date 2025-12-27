using WishList.Application.DTOs.Items;
using WishList.Application.DTOs.UserwishLists;
using WishList.Domain.Entities;

namespace WishList.Application.Mappings
{
    public static class UserWishListMappingExtensions
    {
        public static UserWishListDto? ToDto(this UserWishList? entity)
        {
            if (entity == null) return null;

            return new UserWishListDto
            {
                UserWishListId = entity.UserWishListId,
                WishListName = entity.WishListName,
                UserId = entity.UserId,
                Items = entity.Items
                    .Select(i => i.ToDto())
                    .OfType<ItemDto>()
                    .ToList()
            };
        }
        public static UserWishList ToEntity(this UserWishListCreateDto dto, int userId)
        {
            return new UserWishList
            {
                WishListName = dto.WishListName,
                UserId = userId
            };
        }
    }
}
