using Microsoft.EntityFrameworkCore;
using OurFirstWebApi.Models;

namespace OurFirstWebApi.Data
{
    public class SchoolDbContext : DbContext
    {


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolDb");
        }
    }
}
