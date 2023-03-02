using Microsoft.EntityFrameworkCore;
using H5ServerSideProgrammeringMJ.Models;

namespace H5ServerSideProgrammeringMJ.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
        
        public DbSet<ToDo> ToDos { get; set; }

    }
}
