using WishList.Domain.Entities;

namespace WishList.Application.DTOs.Friendships
{
    public class FriendshipDto
    {
        public int FriendshipId { get; set; }
        public int ReceiverId { get; set; }
        public int RequesterId { get; set; }
        public FriendshipStatus Status { get; set; }
    }
}
