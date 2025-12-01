using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class CuentaBancaria
    {
        [Key]
        public int idcuentaBancaria { get; set; }
        public string banco { get; set; }
        public string numero_cta { get; set; }

        public int tipo_cuenta_idtipo_cuenta { get; set; }
        [ForeignKey("tipo_cuenta_idtipo_cuenta")]
        public TipoCuenta TipoCuenta { get; set; }

        public ICollection<Donacion> Donaciones { get; set; }
    }
}
