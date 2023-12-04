using Microsoft.EntityFrameworkCore;
using System.Numerics;
using ProyectoBackendHerbert.Models;

namespace ProyectoBackendHerbert.Context
{
    public class AplicacionContext : DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
            : base(options)
        {

        }
        public DbSet<Avion> Avion { get; set; }
        public DbSet<Hangar> Hangar { get; set; }
        public DbSet<Piloto> Piloto { get; set; }
        public DbSet<Relacion> Relacion { get; set; }



    }
}
