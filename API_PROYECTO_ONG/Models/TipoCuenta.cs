using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class TipoCuenta
    {
        [Key]
        public int idtipo_cuenta { get; set; }
        public string descripcion_cuenta { get; set; }

        public ICollection<CuentaBancaria> Cuentas { get; set; }
        public ICollection<Donacion> Donaciones { get; set; }
    }
}
