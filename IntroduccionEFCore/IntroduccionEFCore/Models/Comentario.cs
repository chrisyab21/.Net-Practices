using System.ComponentModel.DataAnnotations.Schema;

namespace IntroduccionEFCore.Models
{
    public class Comentario
    {

        public int Id { get; set; }

        public string? Contenido { get; set; }
        public bool Recomendar { get; set; }

        public int PeliculaId { get; set; }

        [ForeignKey("PeliculaId")]
        public Pelicula Pelicula { get; set; } = null!;

    }
}
