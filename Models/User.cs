using System.ComponentModel.DataAnnotations;

namespace ScholarshipManagement.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; } = string.Empty;  // Lưu mật khẩu đã mã hóa

        [Required]
        [RegularExpression("^(Student|Admin)$", ErrorMessage = "Vai trò phải là Student hoặc Admin")]
        public string Role { get; set; } = string.Empty;  // Student hoặc Admin

        // Liên kết với các đơn xin học bổng của sinh viên
        public ICollection<Application>? Applications { get; set; }
    }
}
