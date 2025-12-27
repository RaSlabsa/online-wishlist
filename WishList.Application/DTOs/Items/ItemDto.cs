namespace WishList.Application.DTOs.Items
{
    public class ItemDto
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public string ItemURL { get; set; } = string.Empty;
        public int UserWishListId { get; set; }
        public int? BookedByUserId { get; set; }
    }
}
