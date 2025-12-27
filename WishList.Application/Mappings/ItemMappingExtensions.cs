using WishList.Application.DTOs.Items;
using WishList.Domain.Entities;

namespace WishList.Application.Mappings
{
    public static class ItemMappingExtensions
    {
        public static ItemDto? ToDto(this Item? entity)
        {
            if (entity == null) return null;

            return new ItemDto
            {
                ItemId = entity.ItemId,
                ItemName = entity.ItemName,
                ItemURL = entity.ItemURL,
                UserWishListId = entity.UserWishListId,
                BookedByUserId = entity.BookedByUserId
            };
        }
        public static Item ToEntity(this ItemCreateDto dto, int wishListId)
        {
            return new Item
            {
                ItemName = dto.ItemName,
                ItemURL = dto.ItemURL,
                UserWishListId = wishListId,
            };
        }
    }
}
