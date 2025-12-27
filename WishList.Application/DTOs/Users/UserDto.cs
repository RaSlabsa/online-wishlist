using WishList.Application.DTOs.Friendships;
using WishList.Domain.Entities;

namespace WishList.Application.DTOs.Users
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<FriendshipDto> SendFriendRequest { get; set; } = new List<FriendshipDto>();
        public ICollection<FriendshipDto> ReceivedFriendRequest { get; set; } = new List<FriendshipDto>();
    }
}
