namespace OCS.Models
{
    public class Doctor
    {
        public int DoctorId { get; set;}
        public string DoctorsName { get; set;}
        public string DOB { get; set;}
        public string DOJ { get; set; }
        public string Gender { get; set;}
        public string Qualification { get; set;}
        public string Specialization { get; set;}
        public string YearsOfExperience { get; set;}
        public string Address { get; set;}
        public int ContactNumber { get; set;}

    }
   
    //public required ICollection<Appointment> Appointments { get; set; }
}
