using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class Proyecto_ONG
    {
        [Key]
        public int idproyecto_ONG { get; set; }
        public string nombre_proyecto { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public string presupuesto_otorgado { get; set; }

        public ICollection<ProyectoONG_has_ODS>? ODS { get; set; } = new List<ProyectoONG_has_ODS>();
        public ICollection<ProyectoONG_has_Pais>? Paises { get; set; } = new List<ProyectoONG_has_Pais>();
        public ICollection<Actividades>? Actividades { get; set; } = new List<Actividades>();
        public ICollection<Proyecto_ONG_has_proyecto_voluntario>? ProyectoVoluntarios { get; set; } = new List<Proyecto_ONG_has_proyecto_voluntario>();
        public ICollection<Proyecto_ONG_has_proyecto_empleado>? ProyectoEmpleados { get; set; } = new List<Proyecto_ONG_has_proyecto_empleado>();
        public ICollection<Evento>? Eventos { get; set; } = new List<Evento>();
    }
}
