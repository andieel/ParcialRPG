using ParcialRPG.Models;
using System.Text.Json;

namespace ParcialRPG.Data
{
    public static class JuegoData
    {
        public static List<Personaje> Personajes = new List<Personaje>();

        static string ruta = "Archivos/personajes.json";

        public static void GuardarJson()
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(Personajes, opciones);

            File.WriteAllText(ruta, json);
        }

        public static void CargarJson()
        {
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);

                Personajes = JsonSerializer.Deserialize<List<Personaje>>(json)
                             ?? new List<Personaje>();
            }
        }
    }
}