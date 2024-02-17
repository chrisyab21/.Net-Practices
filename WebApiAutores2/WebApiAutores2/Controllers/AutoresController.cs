using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores2.Modelos;

namespace WebApiAutores2.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        private readonly AplicattionDbContext context;

        public AutoresController(AplicattionDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get()
        {

            List<Autor> list1 = await context.Autores.ToListAsync();

            return list1;

        }


        [HttpPost]
        public async Task<ActionResult> Post(Autor autor)
        {
            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Autor autor)
        {
            if (autor.Id != id)
            {
                return BadRequest("El id del autor no coincide con el id de la Url");

            }

            var existe = await context.Autores.AnyAsync((x) => x.Id == id);

            if (existe == false)
            {

                return NotFound();

            }

            context.Update(autor);
            await context.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {

            var existe =  await context.Autores.AnyAsync((x) => x.Id == id);

            if(existe == false)
            {

                return NotFound();

            }

            context.Remove(new Autor() { Id = id});
            await context.SaveChangesAsync();
            return Ok();

        }

    }
}
