using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class TipoTransaccion
    {
        [Key]
        public int idtipo_transaccion { get; set; }
        public string descripcion_transaccion { get; set; }

        public ICollection<Transaccion> Transacciones { get; set; }
    }
}
