using Microsoft.AspNetCore.Mvc;
using Updated_Project.Models;

namespace NewProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Student> students = _context.Students.ToList();
            return View(students);
        }
        [HttpPost]
        public IActionResult Save(List<Student> students)
        {
            if (ModelState.IsValid)
            {
                foreach (var student in students)
                {
                    _context.Students.Add(student);
                }
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            // If model state is not valid, return to the same view with validation errors
            return View("Index", students);
        }

    }
}
