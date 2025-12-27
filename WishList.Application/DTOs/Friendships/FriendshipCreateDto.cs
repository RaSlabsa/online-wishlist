using System.ComponentModel.DataAnnotations;

namespace WishList.Application.DTOs.Friendships
{
    public class FriendshipCreateDto
    {
        [Required]
        public int ReceiverId { get; set; }
    }
}
