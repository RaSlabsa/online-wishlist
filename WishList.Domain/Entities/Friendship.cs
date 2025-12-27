namespace WishList.Domain.Entities
{
    public enum FriendshipStatus
    {
        Pending,
        Accepted,
        Declined,
        Blocked
    }
    public class Friendship
    {
        public int FriendshipId { get; set; }
        public int ReceiverId { get; set; }
        public User Receiver { get; set; } = null!;
        public int RequesterId { get; set; }
        public User Requester { get; set; } = null!;
        public FriendshipStatus Status { get; set; }
    }
}
