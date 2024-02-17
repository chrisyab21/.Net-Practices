using System.ComponentModel.DataAnnotations;

namespace TesisApi.DTOS
{
    public class VueloCreacionDTO
    {

        [StringLength(20)]
        public string NroVuelo { get; set; }

        [StringLength(40)]
        public string Aerolinea { get; set; }

        public DateTime FechaDeSalida { get; set; }

        public DateTime FechaDeLlegada { get; set; }

        public string AeropuertoOrigen { get; set; }

        public string AeropuertoDestino { get; set; }
    }
}
