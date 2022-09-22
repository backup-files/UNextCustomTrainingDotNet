using System.Linq;
using WebApplicationToo.Data.Entities;

namespace WebApplicationToo.Data
{
    public static class InitialData
    {
        public static void Seed(this CollegeDbContext context)
        {
            if(!context.Students.Any())
            {
                context.Students.Add(new Student { Name = "A" });
                context.Students.Add(new Student { Name = "B" });
                context.Students.Add(new Student { Name = "C" });
                context.Students.Add(new Student { Name = "D" });
                context.Students.Add(new Student { Name = "E" });
                context.SaveChanges();
            }
        }
    }
}
