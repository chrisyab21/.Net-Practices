using IntroduccionEFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroduccionEFCore.Models.Configuraciones
{
    public class PeliculaActorConfiguration : IEntityTypeConfiguration<PeliculaActor>
    {
        public void Configure(EntityTypeBuilder<PeliculaActor> builder)
        {
          // Prueba You = new Prueba(); 
            
            builder.HasKey((Pa) => new{ Pa.PeliculaId, Pa.ActorId });
        }
    }


    public class Prueba
    {
        public int PeliculaIdX { get; set; }

        public int ActorIdX { get; set; }


    }
}
