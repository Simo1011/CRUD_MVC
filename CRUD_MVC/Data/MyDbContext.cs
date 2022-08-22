using CRUD_MVC.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Gadgets> Gadgets { get; set; }
    }
}
