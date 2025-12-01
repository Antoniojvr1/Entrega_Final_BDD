using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Usuario
    {
        [Key]
        public int idusuario { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasena { get; set; }

        public int empleado_idempleado { get; set; }
        [ForeignKey("empleado_idempleado")]
        public Empleado Empleado { get; set; }

        public int ONG_idONG { get; set; }
        [ForeignKey("ONG_idONG")]
        public ONG ONG { get; set; }

        public ICollection<RolUsuario> Roles { get; set; }
    }
}
