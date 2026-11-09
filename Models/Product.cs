using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStore.Web.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn danh mục")]
        public int CategoryId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Giá bán")]
        public decimal Price { get; set; }

        [Display(Name = "Số lượng tồn")]
        public int StockQuantity { get; set; }

        public string? Barcode { get; set; }

        public Category? Category { get; set; }
    }
}
