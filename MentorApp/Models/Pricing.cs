namespace MentorApp.Models;

public class Pricing:BaseEntity
{
    public int Price { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsAdvanced { get; set; }
    public List<Service> Services { get; set; }
}
