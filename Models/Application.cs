using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScholarshipManagement.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }

        [Required]
        [ForeignKey("User")]
        public int StudentID { get; set; }  // Khóa ngoại liên kết User

        [Required]
        [ForeignKey("Scholarship")]
        public int ScholarshipID { get; set; }  // Khóa ngoại liên kết Scholarship

        [Required]
        [RegularExpression("^(Pending|Approved|Rejected)$", ErrorMessage = "Trạng thái phải là Pending, Approved hoặc Rejected")]
        public string Status { get; set; } = "Pending";  // Trạng thái hồ sơ

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime SubmissionDate { get; set; } = DateTime.Now;  // Ngày đăng ký

        // Liên kết với User và Scholarship
        public User? Student { get; set; }
        public Scholarship? Scholarship { get; set; }
    }
}
