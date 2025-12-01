using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Area
    {
        [Key]
        public int idarea { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public int sede_idsede { get; set; }
        [ForeignKey("sede_idsede")]
        public Sede Sede { get; set; }

        public ICollection<Noticias_has_area> Noticias { get; set; }
    }
}
