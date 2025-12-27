using WishList.Application.DTOs.Items;

namespace WishList.Application.DTOs.UserwishLists
{
    public class UserWishListDto
    {
        public int UserWishListId { get; set; }
        public string WishListName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public ICollection<ItemDto> Items { get; set; } = new List<ItemDto>();
    }
}
