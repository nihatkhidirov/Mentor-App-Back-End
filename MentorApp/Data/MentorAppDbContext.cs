using MentorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Data;

public class MentorAppDbContext:DbContext
{
    public MentorAppDbContext(DbContextOptions options):base(options)
    {
    }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Mentor> Mentors { get; set; }
    public DbSet<Pricing> Pricings { get; set; }
    public DbSet<Service> Services { get; set; }
}
