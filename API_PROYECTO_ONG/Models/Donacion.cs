using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Donacion
    {
        [Key]
        public int iddonacion { get; set; }

        public string monto { get; set; }
        public DateTime fecha_donacion { get; set; }

        public int? voluntario_idvoluntario { get; set; }
        [ForeignKey("voluntario_idvoluntario")]
        public Voluntario? Voluntario { get; set; }

        public int? cuenta_bancaria_idcuenta_bancaria { get; set; }
        [ForeignKey("cuenta_bancaria_idcuenta_bancaria")]
        public CuentaBancaria? CuentaBancaria { get; set; }

        
        public ICollection<Transaccion>? Transacciones { get; set; }
    }
}
