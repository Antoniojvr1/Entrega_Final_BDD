using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Evento
    {
        [Key]
        public int idEvento { get; set; }
        public string nombreEvento { get; set; }
        public string descripcionEvento { get; set; }
        public DateTime fechaInicio_evento { get; set; }
        public DateTime fechaFin_evento { get; set; }
        public string lugar { get; set; }

        public int proyecto_ONG_idproyecto_ONG { get; set; }
        [ForeignKey("proyecto_ONG_idproyecto_ONG")]
        public Proyecto_ONG Proyecto { get; set; }
    }
}
