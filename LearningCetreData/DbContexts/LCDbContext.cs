using LearningCetreDomin.Entity;
using Microsoft.EntityFrameworkCore;

namespace LearningCetreData.DbContexts
{
    public class LCDbContext : DbContext
    {
        public LCDbContext(DbContextOptions<LCDbContext> options)
            : base(options) {}

        DbSet<User> Users { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<CourseStudents> CourseStudents { get; set; }
    }
}
