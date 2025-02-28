
using Festivos.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Festivos.Infraesctructura.Persistencia.FestivosContext
{
    public class FestivoContext : DbContext
    {
        public FestivoContext(DbContextOptions<FestivoContext> options) : base(options) 
        {
        }

        public DbSet<Tipo> Tipos { get; set; }

        public DbSet<Festivo> Festivos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tipo>(entidad => 
            {
                entidad.HasKey(t => t.Id);
                entidad.Property(t=> t.Nombre);
            });

            modelBuilder.Entity<Festivo>(entidad =>
            {
                entidad.HasKey(f => f.Id);
                entidad.Property(f => f.Nombre);

                entidad.HasKey(f => f.Dia);

                entidad.HasKey(f => f.Mes);

                entidad.HasKey(f => f.DiasPascuas);

                entidad.HasOne(f => f.Tipo);
            });


        }

    }
}
