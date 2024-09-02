using MentorApp.Data;
using MentorApp.Models;
using MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(MentorAppDbContext mentorAppDbContext)
        {
            _mentorAppDbContext = mentorAppDbContext;
        }
        private MentorAppDbContext _mentorAppDbContext;
        public IActionResult Index()
        {
            IEnumerable<Course> courses = _mentorAppDbContext.Courses.Include(c => c.Trainer).Include(c=>c.Category).AsEnumerable();
            IEnumerable<Mentor> mentors = _mentorAppDbContext.Mentors.Include(m => m.Category).AsEnumerable();
            HomeVM vm = new() { Courses = courses, Mentors = mentors };
            return View(vm);
        }
    }
}
