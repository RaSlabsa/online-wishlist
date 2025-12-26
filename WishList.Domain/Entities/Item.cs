namespace WishList.Domain.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public string ItemURL { get; set; } = string.Empty;
        public int WishListId { get; set; }
        public int? BookedByUserId { get; set; }
    }
}
