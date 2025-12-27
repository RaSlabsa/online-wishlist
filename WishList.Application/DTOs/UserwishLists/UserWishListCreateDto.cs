using System.ComponentModel.DataAnnotations;
using WishList.Domain.Entities;

namespace WishList.Application.DTOs.UserwishLists
{
    public class UserWishListCreateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string WishListName { get; set; } = string.Empty;
    }
}
