using Microsoft.AspNetCore.Mvc;
using TaskWeb.Data;
using TaskWeb.Models;

namespace TaskWeb.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            this._context = context;
        }
        [HttpGet]

        public IActionResult Index()
        {
            var student = _context.Students.ToList();
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            else
            {
                return View("Create");
            }
            return RedirectToAction("Index");
        }
    }
}
