using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class Capacitacion
    {
        [Key]
        public int idcapacitacion { get; set; }
        public DateTime fecha_capacitacion { get; set; }

        public ICollection<VoluntarioCapacitacion> Voluntarios { get; set; }
    }
}
