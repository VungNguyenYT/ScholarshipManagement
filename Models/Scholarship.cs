using System.ComponentModel.DataAnnotations;

namespace ScholarshipManagement.Models
{
    public class Scholarship
    {
        [Key]
        public int ScholarshipID { get; set; }

        [Required(ErrorMessage = "Tên học bổng không được để trống")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả học bổng")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Số tiền hỗ trợ không được để trống")]
        [Range(100000, 100000000, ErrorMessage = "Số tiền phải từ 100,000 đến 100,000,000")]
        public decimal Amount { get; set; }  // Số tiền học bổng

        [Required]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }  // Hạn cuối đăng ký

        // Liên kết với các đơn đăng ký
        public ICollection<Application>? Applications { get; set; }
    }
}
