using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    public class StudentAccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(StudentLoginModel model)
        {
            if (string.IsNullOrWhiteSpace(model.StudentId) ||
                string.IsNullOrWhiteSpace(model.Email) ||
                string.IsNullOrWhiteSpace(model.Password) ||
                string.IsNullOrWhiteSpace(model.Course) ||
                string.IsNullOrWhiteSpace(model.Semester))
            {
                ViewBag.Message = "Please complete all the fields.";
                return View(model);
            }

            ViewBag.Message = "Student login submitted successfully!";
            return View(model);
        }
    }
}