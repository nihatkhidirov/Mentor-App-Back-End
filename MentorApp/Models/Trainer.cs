namespace MentorApp.Models;

public class Trainer:BaseEntity
{
    public string ImageUrl { get; set; }
    public int FollowerCount { get; set; }
    public int LikeCount { get; set; }
    public List<Course> Courses { get; set; }
}
