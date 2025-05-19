namespace ClinicBookingSystemAPP.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } // e.g., "Scheduled", "Completed", "Cancelled"
        public string Notes { get; set; } // Additional notes for the appointment
        public virtual Patient Patient { get; set; }// Navigation property to the Patient entity
        public virtual Doctor Doctor { get; set; }// Navigation property to the Doctor entity
    }
}
