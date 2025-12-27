using System.ComponentModel.DataAnnotations;
using WishList.Domain.Entities;

namespace WishList.Application.DTOs.Users
{
    public class UserCreateDto
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
