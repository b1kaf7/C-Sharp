using Microsoft.EntityFrameworkCore;
using CRUD_MVC.Models;

namespace CRUD_MVC.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}