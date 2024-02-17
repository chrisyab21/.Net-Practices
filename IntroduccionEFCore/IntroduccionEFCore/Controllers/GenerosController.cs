using AutoMapper;
using IntroduccionEFCore.DTOS;
using IntroduccionEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionEFCore.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenerosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public async Task<ActionResult> Post(GeneroCreacionDTO generoCreacion)
        {

            //var genero = new Genero()
            //{

            //    Nombre = generoCreacion.Nombre,
            //};

            var genero = mapper.Map<Genero>(generoCreacion);
            context.Add(genero);
            await context.SaveChangesAsync();
            return Ok();

        }

        [HttpPost("varios")]
        public async Task<ActionResult> Post(GeneroCreacionDTO[] generoCreacion)
        {

            var generos = mapper.Map<Genero[]>(generoCreacion);
            context.AddRange(generos);
            await context.SaveChangesAsync();
            return Ok();

        }


    }
}
