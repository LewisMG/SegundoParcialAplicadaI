using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SegundoParcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vehiculos> vehiculos { get; set; }
        public DbSet<Mantenimiento> mantenimiento { get; set; }
        public DbSet<Talleres> talleres { get; set; }
        public DbSet<Articulos> articulos { get; set; }
        public DbSet<EntradaArticulos> entradaArticulos { get; set; }
        
        public Contexto() : base("ConStr") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
