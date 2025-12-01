using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class Rol
    {
        [Key]
        public int idrol { get; set; }
        public string nombre_rol { get; set; }

        public ICollection<RolUsuario>? RolUsuarios { get; set; } = new List<RolUsuario>();
    }
}
