using System.ComponentModel.DataAnnotations;

namespace ParcialRPG.Models
{
    public class Arquero: Personaje
    {
        [Required]
        public string TipoArco { get; set; } = string.Empty;

        [Range(0, 100)]
        public int Precision { get; set; }
    }
}
