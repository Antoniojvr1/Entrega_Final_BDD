using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Gasto
    {
        [Key]
        public int idgasto { get; set; }
        public string monto { get; set; }
        public DateTime fecha { get; set; }

        public int tipo_gasto_idtipo_gasto { get; set; }
        [ForeignKey("tipo_gasto_idtipo_gasto")]
        public TipoGasto TipoGasto { get; set; }

        public ICollection<Transaccion> Transacciones { get; set; }
        public ICollection<Factura> Facturas { get; set; }
    }
}
