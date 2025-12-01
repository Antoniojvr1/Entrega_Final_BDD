using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class ProyectoONG_has_Pais
    {
        public int proyecto_ONG_idproyecto_ONG { get; set; }
        public int pais_idpais { get; set; }

        [ForeignKey("proyecto_ONG_idproyecto_ONG")]
        [JsonIgnore]
        public Proyecto_ONG? Proyecto { get; set; }

        [ForeignKey("pais_idpais")]
        [JsonIgnore]
        public Pais? Pais { get; set; }
    }
}
