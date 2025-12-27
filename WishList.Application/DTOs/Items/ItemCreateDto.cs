using System.ComponentModel.DataAnnotations;

namespace WishList.Application.DTOs.Items
{
    public class ItemCreateDto
    {
        [Required]
        [StringLength(100)]
        public string ItemName { get; set; } = string.Empty;

        [Url]
        public string ItemURL { get; set; } = string.Empty;
    }
}
