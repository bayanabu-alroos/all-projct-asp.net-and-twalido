using APITask.Models;
using APITask.Models.EntityConfigartion;
using Microsoft.EntityFrameworkCore;

namespace APITask.Context
{
    public class TaskAPIDbContext : DbContext
    {
        public TaskAPIDbContext(DbContextOptions<TaskAPIDbContext> options) :base (options) { }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserEntityConfigartion());
        }
        public virtual DbSet<User> Users { get; set; }

    }
}
