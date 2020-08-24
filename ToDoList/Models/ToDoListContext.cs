using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; } //new line
    public virtual DbSet<Item> Items { get; set; }          //changed

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}