using Microsoft.EntityFrameworkCore;
using StudentsWeb.Models;

namespace StudentsWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        //Add the Student Model & the others Models here, at the next way: 
        public DbSet<Student> Student { get; set; } 
    }
}
