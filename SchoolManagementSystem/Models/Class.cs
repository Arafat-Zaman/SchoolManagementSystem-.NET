namespace SchoolManagementSystem.Models
{
    public class Class
    {
        public string ClassName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public Teacher Teacher { get; set; }

        public Class(string className, Teacher teacher)
        {
            ClassName = className;
            Teacher = teacher;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
