using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Actividades
    {
        [Key]
        public int idactividades { get; set; }
        public string nombre_Actividad { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }

        public int proyecto_ONG_idproyecto_ONG { get; set; }
        [ForeignKey("proyecto_ONG_idproyecto_ONG")]
        public Proyecto_ONG Proyecto { get; set; }
    }
}
