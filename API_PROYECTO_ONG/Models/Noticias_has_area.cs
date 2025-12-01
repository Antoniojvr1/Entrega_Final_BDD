using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PROYECTO_ONG.Models
{
    public class Noticias_has_area
    {
        [Key, Column(Order = 1)]
        public int Noticias_idNoticias { get; set; }

        [Key, Column(Order = 2)]
        public int area_idarea { get; set; }

        public Noticias Noticias { get; set; }
        public Area Area { get; set; }
    }

}
