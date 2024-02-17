using System.ComponentModel.DataAnnotations;

namespace manejoPresupuesto.Models
{
    public class TipoCuenta
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(maximumLength:50,MinimumLength =4, ErrorMessage ="La longitud del campo {0} debe estar entre {2} y {1}")]
        [Display(Name ="Nombre tipos cuentas")]
        public string? Nombre { get; set; }

        public int UsuarioID { get; set; }

        public int Orden { get; set; }

        //Pruebas de otras validaciones

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [EmailAddress(ErrorMessage ="El campo debe se un email")]

        public string? Email  { get; set; }

        [Range(minimum:18, maximum:100, ErrorMessage ="El valor debe estar entre {1} y {2}")]
        public int Edad { get; set; }

        [Url(ErrorMessage ="El campo debe ser una Url valida")]
        public string? Url { get; set; }

        [CreditCard(ErrorMessage ="La tarjeta de credito no es valida")]
        [Display(Name ="Tarjeta de Credito")]
        public string? TarjetaDeCredito { get; set; }







    }
}
