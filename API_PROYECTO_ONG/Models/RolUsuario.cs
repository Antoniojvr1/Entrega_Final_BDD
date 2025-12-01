using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class RolUsuario
    {
        public int idrol { get; set; }
        public int usuario_idusuario { get; set; }
        public string descripcion_rol { get; set; }

        [ForeignKey("idrol")]
        [JsonIgnore]
        public Rol? Rol { get; set; }

        [ForeignKey("usuario_idusuario")]
        [JsonIgnore]
        public Usuario? Usuario { get; set; }
    }
}
