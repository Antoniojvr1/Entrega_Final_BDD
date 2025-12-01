using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_PROYECTO_ONG.Models
{
    public class Persona
    {
        [Key]
        public int idPersona { get; set; }

        public string P_nombre { get; set; }
        public string S_nombre { get; set; }
        public string P_apellido { get; set; }
        public string S_apellido { get; set; }
        public DateTime fecha_nac { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }

        
        public ICollection<Telefono>? Telefonos { get; set; }
        public ICollection<Voluntario>? Voluntarios { get; set; }
        public ICollection<Empleado>? Empleados { get; set; }

        
    }
}
