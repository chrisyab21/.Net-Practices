using AutoMapper;
using IntroduccionEFCore.DTOS;
using IntroduccionEFCore.Models;

namespace IntroduccionEFCore.Utilidades
{
    public class AutoMapperProfiles: Profile

    {
        public AutoMapperProfiles()
        {
            CreateMap<GeneroCreacionDTO, Genero>();
            CreateMap<ActorCreacionDTO, Actor>();

            CreateMap<PeliculaCreacionDTO, Pelicula>().ForMember((ent) => ent.Generos, dto => dto.MapFrom(origen => origen.Generos.Select(id => new Genero() { Id = id })));

            CreateMap<PelicularActorCreacionDTO, PeliculaActor>();
           
        }
    }
}
