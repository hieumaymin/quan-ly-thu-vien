using System.ComponentModel.DataAnnotations;

namespace MyLibraryDemo.Data.Models
{
    public class Reader
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên độc giả")]
        [MaxLength(255, ErrorMessage = "Tên độc giả không được vượt quá 255 ký tự")]
        [Display(Name = "Tên độc giả")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ email")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        [MaxLength(255, ErrorMessage = "Email không được vượt quá 255 ký tự")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Số điện thoại chỉ được chứa chữ số")]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "Số điện thoại phải từ 10 đến 11 chữ số")]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}