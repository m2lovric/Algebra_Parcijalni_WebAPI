using Microsoft.EntityFrameworkCore;

namespace Ispit.API.Models
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<TodoList> TodoList { get; set; }
    }
}
