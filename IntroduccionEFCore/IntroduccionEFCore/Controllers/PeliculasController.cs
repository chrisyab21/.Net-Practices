using AutoMapper;
using IntroduccionEFCore.DTOS;
using IntroduccionEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionEFCore.Controllers
{
    [ApiController]
    [Route("Peliculas")]
    public class PeliculasController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PeliculasController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]

        public async Task<ActionResult> Post(PeliculaCreacionDTO peliculaCreacionDTO)
        {
            var pelicula = mapper.Map<Pelicula>(peliculaCreacionDTO);

            if(pelicula.Generos is not null)
            {

                foreach (var genero in pelicula.Generos)
                {
                    context.Entry(genero).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
                }
            }


            if(pelicula.PeliculasActores is not null)
            {

                for (int i = 0; i < pelicula.PeliculasActores.Count; i++)
                {
                    pelicula.PeliculasActores[i].Orden = i + 1;


                }
            }

            context.Add(pelicula);
            await context.SaveChangesAsync();
            return Ok();

        }
    }
}
