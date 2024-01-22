namespace OCS.Models
{
    public class DoctorIntimation
    {
        public int Id { get; set; }
        public int DoctorId { get; set; } // Foreign key for Doctor
        public DateTime Date { get; set; }
    }
}
