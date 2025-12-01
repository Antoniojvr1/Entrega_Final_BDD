using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Transaccion
    {
        [Key]
        public int idtransaccion { get; set; }
        public DateTime fecha_transaccion { get; set; }

        public int tipo_transaccion_idtipo_transaccion { get; set; }
        [ForeignKey("tipo_transaccion_idtipo_transaccion")]
        public TipoTransaccion TipoTransaccion { get; set; }

        public int donacion_iddonacion { get; set; }
        [ForeignKey("donacion_iddonacion")]
        public Donacion Donacion { get; set; }

        public int gasto_idgasto { get; set; }
        [ForeignKey("gasto_idgasto")]
        public Gasto Gasto { get; set; }
    }
}
