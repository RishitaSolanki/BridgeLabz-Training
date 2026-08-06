namespace HealthClinic.Entities
{
    public class Patient
    {
        public int PatientID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public char Gender { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}