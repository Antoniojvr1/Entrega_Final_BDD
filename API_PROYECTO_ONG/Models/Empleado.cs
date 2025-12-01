using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Empleado
    {
        [Key]
        public int idempleado { get; set; }
        public DateTime fecha_contratacion { get; set; }
        public string cargo { get; set; }
        public string salario { get; set; }

        public int Persona_idPersona { get; set; }
        [ForeignKey("Persona_idPersona")]
        public Persona Persona { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<ProyectoEmpleado> ProyectoEmpleados { get; set; }
    }
}
