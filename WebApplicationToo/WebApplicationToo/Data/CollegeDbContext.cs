using Microsoft.EntityFrameworkCore;
using WebApplicationToo.Data.Entities;

namespace WebApplicationToo.Data
{
    public class CollegeDbContext: DbContext
    {
        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; }
    }
}
