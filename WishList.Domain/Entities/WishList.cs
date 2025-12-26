namespace WishList.Domain.Entities
{
    internal class WishList
    {
        public int WishListId { get; set; }
        public int UserId { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
