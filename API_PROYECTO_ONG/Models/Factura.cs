using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Factura
    {
        [Key]
        public int idfactura { get; set; }
        public string numero_factura { get; set; }
        public string donador_proveedor { get; set; }
        public string monto { get; set; }
        public DateTime fecha_emision { get; set; }

        public int metodo_pago_idmetodo_pago { get; set; }
        [ForeignKey("metodo_pago_idmetodo_pago")]
        public MetodoPago MetodoPago { get; set; }

        public int gasto_idgasto { get; set; }
        [ForeignKey("gasto_idgasto")]
        public Gasto Gasto { get; set; }
    }
}
