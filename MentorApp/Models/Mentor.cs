namespace MentorApp.Models;

public class Mentor:BaseEntity
{
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string TwitterUrl { get; set; }
    public string FacebookUrl { get; set; }
    public string InstagramUrl { get; set; }
    public string LinkedinUrl { get; set; }
}
