using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class MetodoPago
    {
        [Key]
        public int idmetodo_pago { get; set; }
        public string descripcion { get; set; }

        public ICollection<Factura> Facturas { get; set; }
    }
}
