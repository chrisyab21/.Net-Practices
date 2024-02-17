using IntroduccionEFCore.Models;
using IntroduccionEFCore.Models.Configuraciones;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IntroduccionEFCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
           
        }

        //Api fluente, configuraciones especificas para campos de tablas en la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            //Agregar configuraciones para el modelo Pelicula

            //modelBuilder.Entity<Pelicula>().HasKey(p => p.Id);
            //modelBuilder.Entity<Pelicula>().Property(p => p.Titulo).HasMaxLength(maxLength: 150);
            //modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno).HasColumnType("date");

            modelBuilder.ApplyConfiguration<Actor>(new ActorConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Comentario>().Property(c => c.Contenido).HasMaxLength(500);
        }


        


        //Configuracioness por defecto
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            //Configurar que todas las propiedades de tipo string migren a la base de datos como nvarchar(150)
            configurationBuilder.Properties<string>().HaveMaxLength(150);    
        }





        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores => Set<Actor>();

        public DbSet<Pelicula> Peliculas
        {
            get { 
                
                return Set<Pelicula>(); 
            
            }
        }

        public DbSet<Comentario> Comentarios => Set<Comentario>();


        public DbSet<PeliculaActor> PeliculasActores => Set<PeliculaActor>();


    }
}
