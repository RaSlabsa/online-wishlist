namespace WishList.Domain.Entities
{
    public enum FriendshipStatus
    {
        Pending,
        Accepted,
        Declined,
        Blocked
    }
    internal class Friendship
    {
        public int FriendshipId { get; set; }
        public int ReceiverId { get; set; }
        public User? Receiver { get; set; }
        public int RequesterId { get; set; }
        public User? Requester { get; set; }
        public FriendshipStatus Status { get; set; }
    }
}
