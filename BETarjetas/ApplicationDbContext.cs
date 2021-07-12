using BETarjetas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BETarjetas
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}
