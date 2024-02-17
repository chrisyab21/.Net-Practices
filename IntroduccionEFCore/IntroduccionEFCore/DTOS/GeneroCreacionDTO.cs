using System.ComponentModel.DataAnnotations;

namespace IntroduccionEFCore.DTOS
{
    public class GeneroCreacionDTO
    {
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
    }
}
