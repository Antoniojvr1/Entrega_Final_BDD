using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class ONG
    {
        [Key]
        public int idONG { get; set; }
        public string nombre_ONG { get; set; }
        public string mision { get; set; }
        public string vision { get; set; }
        public string correo { get; set; }
        public string fecha_Creacion { get; set; }

        public ICollection<Usuario>? Usuarios { get; set; } = new List<Usuario>();
        public ICollection<Sede>? Sedes { get; set; } = new List<Sede>();
    }
}

