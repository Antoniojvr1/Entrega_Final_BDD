using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Voluntario
    {
        [Key]
        public int idvoluntario { get; set; }
        public string disponibilidad { get; set; }

        public int Persona_idPersona { get; set; }
        [ForeignKey("Persona_idPersona")]
        public Persona Persona { get; set; }

        public ICollection<VoluntarioCapacitacion> Capacitaciones { get; set; }
        public ICollection<Donacion> Donaciones { get; set; }
        public ICollection<ProyectoVoluntario> ProyectoVoluntarios { get; set; }
    }
}
