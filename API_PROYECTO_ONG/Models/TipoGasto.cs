using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class TipoGasto
    {
        [Key]
        public int idtipo_gasto { get; set; }
        public string descripcion { get; set; }

        public ICollection<Gasto> Gastos { get; set; }
    }
}
