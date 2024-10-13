using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
    public class StudentsController : Controller
    {
        private StudentRepository _studentRepo = new StudentRepository();

        public IActionResult Index()
        {
            var students = _studentRepo.GetStudents();
            return View(students);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _studentRepo.AddStudent(student);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var student = _studentRepo.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
