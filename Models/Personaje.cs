using System.ComponentModel.DataAnnotations;

namespace ParcialRPG.Models
{
    public class Personaje
    {
        public string Tipo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Range(1, 99, ErrorMessage = "El nivel debe estar entre 1 y 99")]
        public int Nivel { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Los puntos de vida deben ser mayores a 0")]
        public int PV { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La experiencia no puede ser negativa")]
        public int XP { get; set; }
    }
}