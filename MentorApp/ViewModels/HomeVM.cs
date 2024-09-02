using MentorApp.Models;

namespace MentorApp.ViewModels;

public class HomeVM
{
    public IEnumerable<Course> Courses { get; set; }
    public IEnumerable<Mentor> Mentors { get; set; }
}
