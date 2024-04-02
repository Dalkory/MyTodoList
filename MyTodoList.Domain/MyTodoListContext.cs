using Microsoft.EntityFrameworkCore;
using MyTodoList.Domain.Entities;

namespace MyTodoList.Domain
{
    public class MyTodoListContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<TaskApp> Tasks { get; set; }

        public MyTodoListContext(DbContextOptions options) : base(options) 
        {
        }
    }
}
