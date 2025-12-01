using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class Sede
    {
        [Key]
        public int idsede { get; set; }
        public string direccion { get; set; }
        public string responsable { get; set; }

        public int ONG_idONG { get; set; }
        [ForeignKey("ONG_idONG")]
        [JsonIgnore]
        public ONG? ONG { get; set; }

        public ICollection<Area>? Areas { get; set; } = new List<Area>();
    }
}
