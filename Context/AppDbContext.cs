using LanchesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesApp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanches> Lanches { get; set; }


    }
}
