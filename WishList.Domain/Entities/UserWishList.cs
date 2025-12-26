namespace WishList.Domain.Entities
{
    public class UserWishList
    {
        public int UserWishListId { get; set; }
        public string WishListName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
