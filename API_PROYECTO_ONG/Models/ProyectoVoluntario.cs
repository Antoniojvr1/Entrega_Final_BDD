using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class ProyectoVoluntario
    {
        [Key]
        public int idproyecto_voluntario { get; set; }

        public int idvoluntario { get; set; }
        [ForeignKey("idvoluntario")]
        [JsonIgnore]
        public Voluntario? Voluntario { get; set; }

        public ICollection<Proyecto_ONG_has_proyecto_voluntario>? Proyectos { get; set; } = new List<Proyecto_ONG_has_proyecto_voluntario>();
    }
}
