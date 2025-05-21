using System.ComponentModel.DataAnnotations;

namespace MyLibraryDemo.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sách")]
        [MaxLength(255, ErrorMessage = "Tên sách không được vượt quá 255 ký tự")]
        [Display(Name = "Tên sách")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên tác giả")]
        [MaxLength(100, ErrorMessage = "Tên tác giả không được vượt quá 100 ký tự")]
        [Display(Name = "Tác giả")]
        public required string Author { get; set; }

        [Display(Name = "Năm xuất bản")]
        [Range(1800, 2100, ErrorMessage = "Năm xuất bản phải từ 1800 đến 2100")]
        public int? PublicationYear { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả sách")]
        [MaxLength(1000, ErrorMessage = "Mô tả không được vượt quá 1000 ký tự")]
        [Display(Name = "Mô tả")]
        public required string Description { get; set; }

        [Display(Name = "Trạng thái")]
        public bool IsAvailable { get; set; } = true;
    }
}