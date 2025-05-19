using System.ComponentModel.DataAnnotations;

namespace ClinicBookingSystemAPP.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
