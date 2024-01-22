namespace OCS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; } // In real applications, this should be hashed
        public string Address { get; set; }
        public int PhoneNo { get; set; }
        public string EmailID { get; set; }
        public bool LoginStatus { get; set; }

        // Navigation property
        public AilmentDetail AilmentDetail { get; set; }
    }

    public class AilmentDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key
        public string Disease { get; set; }
        public DateTime SinceInfected { get; set; }

        // Navigation property
    }
}
