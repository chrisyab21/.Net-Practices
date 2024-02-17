namespace TesisApi.DTOS
{
    public class Pasaje
    {
        public virtual ICollection<VueloCreacionDTO> Vuelos { get; set; } = new List<VueloCreacionDTO>();

    }
}
