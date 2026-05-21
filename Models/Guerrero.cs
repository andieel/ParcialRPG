using System.ComponentModel.DataAnnotations;

namespace ParcialRPG.Models
{
    public class Guerrero: Personaje
    {
        [Required(ErrorMessage = "Seleccione un tipo de arma")]
        public string TipoArma { get; set; } = string.Empty;

        [Range(1, 100, ErrorMessage = "La defensa física debe estar entre 1 y 100")]
        public int DefensaFisica { get; set; }
    }
}
