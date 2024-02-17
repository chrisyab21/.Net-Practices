using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace IntroduccionEFCore.Models.Configuraciones
{
    public class PeliculaConfiguration : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Titulo).HasMaxLength(maxLength: 150);
            builder.Property(p => p.FechaEstreno).HasColumnType("date");
        }
    }
}
