using System.ComponentModel.DataAnnotations;

namespace ClinicBookingSystemAPP.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string specialization { get; set; }
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } 
    }
}
