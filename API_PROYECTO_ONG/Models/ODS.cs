using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class ODS
    {
        [Key]
        public int idODS { get; set; }
        public string nombre_ODS { get; set; }
        public string descripcion { get; set; }

        public ICollection<ProyectoONG_has_ODS>? ProyectoODS { get; set; } = new List<ProyectoONG_has_ODS>();
    }
}
