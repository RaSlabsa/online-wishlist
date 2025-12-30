using Microsoft.AspNetCore.Identity;

namespace WishList.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public ICollection<Friendship> SendFriendRequest { get; set; } = new List<Friendship>();
        public ICollection<Friendship> ReceivedFriendRequest { get; set; } = new List<Friendship>();
    }
}
