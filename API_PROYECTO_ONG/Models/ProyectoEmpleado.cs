using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class ProyectoEmpleado
    {
        [Key]
        public int idproyecto_empleado { get; set; }

        public int idempleado { get; set; }
        [ForeignKey("idempleado")]
        [JsonIgnore]
        public Empleado? Empleado { get; set; }

        public ICollection<Proyecto_ONG_has_proyecto_empleado>? Proyectos { get; set; } = new List<Proyecto_ONG_has_proyecto_empleado>();
    }
}
