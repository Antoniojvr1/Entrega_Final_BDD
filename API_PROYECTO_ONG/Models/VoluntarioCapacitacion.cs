using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class VoluntarioCapacitacion
    {
        [Key]
        public int voluntario_idvoluntario { get; set; }
        public int capacitacion_idcapacitacion { get; set; }
        public string tema_capacitacion { get; set; }

        [ForeignKey("voluntario_idvoluntario")]
        public Voluntario Voluntario { get; set; }

        [ForeignKey("capacitacion_idcapacitacion")]
        public Capacitacion Capacitacion { get; set; }
    }
}
