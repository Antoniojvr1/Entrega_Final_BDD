using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class Proyecto_ONG_has_proyecto_voluntario
    {
        public int proyecto_ONG_idproyecto_ONG { get; set; }
        public int proyecto_voluntario_idproyecto_voluntario { get; set; }

        [ForeignKey("proyecto_ONG_idproyecto_ONG")]
        [JsonIgnore]
        public Proyecto_ONG? Proyecto { get; set; }

        [ForeignKey("proyecto_voluntario_idproyecto_voluntario")]
        [JsonIgnore]
        public ProyectoVoluntario? ProyectoVoluntario { get; set; }
    }
}
