using System.ComponentModel.DataAnnotations;

namespace ParcialRPG.Models
{
    public class Arquero: Personaje
    {
        [Required(ErrorMessage = "Seleccione un tipo de arco")]
        public string TipoArco { get; set; } = string.Empty;

        [Range(0, 100, ErrorMessage = "La precisión debe estar entre 0 y 100")]
        public int Precision { get; set; }
    }
}
