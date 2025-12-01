using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class Proyecto_ONG_has_proyecto_empleado
    {
        public int proyecto_ONG_idproyecto_ONG { get; set; }
        public int proyecto_empleado_idproyecto_empleado { get; set; }

        [ForeignKey("proyecto_ONG_idproyecto_ONG")]
        [JsonIgnore]
        public Proyecto_ONG? Proyecto { get; set; }

        [ForeignKey("proyecto_empleado_idproyecto_empleado")]
        [JsonIgnore]
        public ProyectoEmpleado? ProyectoEmpleado { get; set; }
    }
}
