using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Donante
    {
        [Key]
        public int iddonante { get; set; }
        public string nombre { get; set; }

        public int tipo_donante_idtipo_donante { get; set; }
        [ForeignKey("tipo_donante_idtipo_donante")]
        public TipoDonante TipoDonante { get; set; }

        public ICollection<Donacion> Donaciones { get; set; }
    }
}
