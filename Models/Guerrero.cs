using System.ComponentModel.DataAnnotations;

namespace ParcialRPG.Models
{
    public class Guerrero: Personaje
    {
        [Required]
        public string TipoArma {  get; set; } = string.Empty;

        [Range (1, 100)]
        public int DefensaFisica { get; set; }
    }
}
