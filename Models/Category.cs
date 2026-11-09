using System.ComponentModel.DataAnnotations;

namespace SmartStore.Web.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [Display(Name = "Tên danh mục")]
        public string CategoryName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
