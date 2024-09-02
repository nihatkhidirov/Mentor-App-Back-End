using MentorApp.Models;

namespace MentorApp.ViewModels;

public class PricingVM
{
    public IEnumerable<Pricing> Pricings { get; set; }
    public IEnumerable<Service> Services { get; set; }
}
