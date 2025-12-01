using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class Noticias
    {
        [Key ]
        public int idNoticias { get; set; }
        public string titulo { get; set; }
        public string informacion { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public string autor { get; set; }

        public ICollection<Noticias_has_area> Areas { get; set; }
    }
}
