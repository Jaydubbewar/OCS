namespace OCS.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string AvailableTimings { get; set; }

        // Navigation property
        public Doctor Doctor { get; set; }
    }
}
