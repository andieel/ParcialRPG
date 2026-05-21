using System.ComponentModel.DataAnnotations;

namespace ParcialRPG.Models
{
    public class Mago : Personaje
    {
        [Required]
        public string EscuelaMagia { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int Mana {  get; set; }
    }
}
