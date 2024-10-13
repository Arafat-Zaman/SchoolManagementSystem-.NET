using SchoolManagementSystem.Models;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data
{
    public class StudentRepository
    {
        private const string FileName = "students.json";
        private List<Student> students = new List<Student>();

        public StudentRepository()
        {
            students = FileHelper.LoadFromFile<Student>(FileName);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            FileHelper.SaveToFile(FileName, students);
        }

        public Student GetStudentById(int id)
        {
            return students.Find(s => s.Id == id);
        }
    }
}
