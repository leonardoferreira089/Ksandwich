using Ksandswich.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ksandswich.Context
{
    public class KsanDbContext : DbContext
    {
        public KsanDbContext (DbContextOptions<KsanDbContext> options) : base(options)
        {
        }

        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }



    }
}
