using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Telefono
    {
        [Key]
        public int idtelefono { get; set; }
        public string numero { get; set; }

        public int Persona_idPersona { get; set; }

        [ForeignKey("Persona_idPersona")]
        public Persona Persona { get; set; }
    }
}
