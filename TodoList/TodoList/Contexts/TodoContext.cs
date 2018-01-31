using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Contexts
{
    public class TodoContext : DbContext
    {
        private string DbPath;
        public DbSet<Todo> Todos { get; set; }

        public static TodoContext Create(string dbPath)
        {
            var todoContext = new TodoContext(dbPath);
            todoContext.Database.EnsureCreated();
            todoContext.Database.Migrate();
            return todoContext;
        }
        public TodoContext(string dbPath)
        {
            DbPath = dbPath;
        }

        public async Task<List<Todo>> GetTodos() => await Todos.ToListAsync();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}
