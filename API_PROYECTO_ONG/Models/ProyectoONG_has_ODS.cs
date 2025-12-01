using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class ProyectoONG_has_ODS
    {
        public int proyecto_ONG_idproyecto_ONG { get; set; }
        public int ODS_idODS { get; set; }

        [ForeignKey("proyecto_ONG_idproyecto_ONG")]
        [JsonIgnore]
        public Proyecto_ONG? Proyecto { get; set; }

        [ForeignKey("ODS_idODS")]
        [JsonIgnore]
        public ODS? ODS { get; set; }
    }
}
