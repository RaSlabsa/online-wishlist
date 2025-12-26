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
        public required User Receiver { get; set; }
        public int RequesterId { get; set; }
        public required User Requester { get; set; }
        public FriendshipStatus Status { get; set; }
    }
}
