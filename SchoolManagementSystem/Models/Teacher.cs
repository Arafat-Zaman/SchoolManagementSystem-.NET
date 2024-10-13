namespace SchoolManagementSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }

        public Teacher(int id, string name, string subject)
        {
            Id = id;
            Name = name;
            Subject = subject;
        }
    }
}
