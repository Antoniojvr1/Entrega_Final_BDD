using System.ComponentModel.DataAnnotations;

namespace API_PROYECTO_ONG.Models
{
    public class Pais
    {
        [Key]
        public int idpais { get; set; }
        public string nombrePais { get; set; }
        public string region { get; set; }

        public ICollection<ProyectoONG_has_Pais>? ProyectoPais { get; set; } = new List<ProyectoONG_has_Pais>();
    }
}
