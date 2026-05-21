using System.ComponentModel.DataAnnotations;

namespace ParcialRPG.Models
{
    public class Mago : Personaje
    {
        [Required(ErrorMessage = "Seleccione una escuela de magia")]
        public string EscuelaMagia { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "El mana debe ser mayor a 0")]
        public int Mana { get; set; }
    }
}
