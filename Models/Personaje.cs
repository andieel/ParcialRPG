using System.ComponentModel.DataAnnotations;

namespace ParcialRPG.Models
{
    public class Personaje
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Range(1, 99)]
        public int Nivel { get; set; }

        [Range(1, int.MaxValue)]
        public int PV { get; set; }

        [Range(0, int.MaxValue)]
        public int XP { get; set; }
    }
}