using System.ComponentModel.DataAnnotations;

namespace IntroduccionEFCore.DTOS
{
    public class ActorCreacionDTO
    {

        [StringLength(150)]
        public string Nombre { get; set; } = null!;
        public decimal Fortuna { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
