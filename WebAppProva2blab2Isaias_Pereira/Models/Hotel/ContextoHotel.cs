using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebAppProva2blab2Isaias_Pereira.Models.Configurations;

namespace WebAppProva2blab2Isaias_Pereira.Models.Hotel
{
    public class ContextoHotel:DbContext
    {
        public ContextoHotel():base("name=ProvaLab2")
        {

        }

        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("dateTime2"));
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar").HasMaxLength(200));

            modelBuilder.Configurations.Add(new HospedeConfig());
            modelBuilder.Properties<int>().Where(c => c.Name == c.PropertyType.Name + "Id").Configure(c => c.IsKey());
            modelBuilder.Entity<Reserva>().MapToStoredProcedures();
            modelBuilder.Entity<Historico>().MapToStoredProcedures();
            modelBuilder.Entity<Categoria>().MapToStoredProcedures();
            modelBuilder.Entity<Hospede>().MapToStoredProcedures();
            modelBuilder.Entity<Endereco>().MapToStoredProcedures();
        }
    }
}