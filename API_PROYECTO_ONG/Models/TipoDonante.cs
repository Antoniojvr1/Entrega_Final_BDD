using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class TipoDonante
    {
        [Key]
        public int idtipo_donante { get; set; }
        public string descripcion { get; set; }

        public ICollection<Donante> Donantes { get; set; }
    }
}
