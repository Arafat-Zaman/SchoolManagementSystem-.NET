namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public Dictionary<string, int> Grades { get; set; } = new Dictionary<string, int>();

        public Student(int id, string name, string className)
        {
            Id = id;
            Name = name;
            ClassName = className;
        }

        public void AddGrade(string subject, int grade)
        {
            Grades[subject] = grade;
        }

        public double GetAverageGrade()
        {
            if (Grades.Count == 0) return 0;
            return Grades.Values.Average();
        }
    }
}
