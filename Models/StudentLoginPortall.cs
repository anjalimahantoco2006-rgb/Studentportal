namespace StudentPortal.Models
{
    public class StudentLoginModel
    {
        public string StudentId { get; set; } = "";

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public string Course { get; set; } = "";

        public string Semester { get; set; } = "";
    }
}