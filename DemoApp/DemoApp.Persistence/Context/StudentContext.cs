using DemoApp.Domain.Entities;
using DemoApp.Persistence.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Persistence.Context
{
    public class StudentContext : DbContext, IStudentContext
    {
        public DbSet<Students>? Students { get; set; } 
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }
    }
}
