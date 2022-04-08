using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace c__api.Models {
  public class TodoContext : DbContext {
    public TodoContext(DbContextOptions<TodoContext> options) : base(options) {
    } 

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
  }
}