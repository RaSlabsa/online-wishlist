namespace WishList.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Friendship> SendFriendRequest { get; set; } = new List<Friendship>();
        public ICollection<Friendship> ReceivedFriendRequest { get; set; } = new List<Friendship>();
    }
}
