namespace IntroduccionEFCore.DTOS
{
    public class PeliculaCreacionDTO
    {

        public string Titulo { get; set; } = null!;
        public bool EnCines { get; set; }

        public DateTime FechaEstreno { get; set; }

        public List<int> Generos { get; set; } = new List<int>();
        public List<PelicularActorCreacionDTO> PeliculasActores { get; set; } = new List<PelicularActorCreacionDTO>();
    }
}
