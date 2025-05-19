using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibraryDemo.Data.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn sách")]
        [Display(Name = "Sách")]
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book? Book { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn độc giả")]
        [Display(Name = "Độc giả")]
        public int ReaderId { get; set; }

        [ForeignKey("ReaderId")]
        public Reader? Reader { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ngày mượn")]
        [Display(Name = "Ngày mượn")]
        [DataType(DataType.Date)]
        public DateTime LoanDate { get; set; }

        [Display(Name = "Ngày trả")]
        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }

        [NotMapped]
        public string Status => ReturnDate.HasValue ? "Đã trả" : "Chưa trả";
    }
}