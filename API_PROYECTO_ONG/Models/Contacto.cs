using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class Contacto
    {
        [Key]
        public int idContacto { get; set; }
        public string numero { get; set; }
        public string correo { get; set; }
        public string consultas { get; set; }
    }
}
