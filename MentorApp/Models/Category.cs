namespace MentorApp.Models;

public class Category:BaseEntity
{
    public List<Course> Courses { get; set; }
    public List<Mentor> Mentors { get; set; }
};
