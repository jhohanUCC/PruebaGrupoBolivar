using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPruebaDavivienda.Data
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex()
        {
        }

        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Cliente>().HasKey(t => t.IdTercero);
            modelBuilder
               .Entity<Producto>().HasKey(t => t.IdProducto);
        }



    }
}

