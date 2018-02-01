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

        public async Task<int> StoreTodo(Todo todo)
        {
            if (todo.Id == 0)
            {
                await Todos.AddAsync(todo);
            }
            return await SaveChangesAsync();
        }
        public async Task<int> DeleteTodo(Todo todo)
        {
            Todos.Remove(todo);
            return await SaveChangesAsync();
        }
        public async Task<Todo> GetTodo(int id) => await Todos.SingleAsync(todo => todo.Id == id);
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}
