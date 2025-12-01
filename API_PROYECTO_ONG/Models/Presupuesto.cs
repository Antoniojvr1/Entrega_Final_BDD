using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class Presupuesto
    {
        [Key]
        public int idpresupuesto { get; set; }
        public string monto_asignado { get; set; }
        public string monto_usado { get; set; }
    }
}
