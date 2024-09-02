using MentorApp.Data;
using MentorApp.Models;
using MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers
{
    public class PricingController : Controller
    {
        private MentorAppDbContext _mentorAppDbContext;
        public PricingController(MentorAppDbContext mentorAppDbContext)
        {
            _mentorAppDbContext = mentorAppDbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Service> services = _mentorAppDbContext.Services.AsEnumerable();
            IEnumerable<Pricing> pricings = _mentorAppDbContext.Pricings.Include(p => p.Services).AsEnumerable();

            PricingVM pricingVM = new() { Pricings=pricings, Services=services};

            return View(pricingVM);
        }
    }
}
