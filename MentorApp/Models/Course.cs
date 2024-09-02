namespace MentorApp.Models;

public class Course: BaseEntity
{
    public string Description { get; set; }
    public int Price { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }
    public Trainer Trainer { get; set; }
    public int TrainerId { get; set; }
    public string ImageUrl { get; set; }
}
