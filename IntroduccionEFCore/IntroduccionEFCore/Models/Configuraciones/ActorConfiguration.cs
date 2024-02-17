﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace IntroduccionEFCore.Models.Configuraciones
{

    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)

        {

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nombre).HasMaxLength(maxLength: 150);
            builder.Property(a => a.FechaNacimiento).HasColumnType("date");
            builder.Property(a => a.Fortuna).HasPrecision(18, 2);
           
        }
    }
}
