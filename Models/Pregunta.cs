using System;

namespace DesafioCalendario.Models
{
    public class Pregunta : IPregunta
    {
        // El objeto "pregunta" implementa la interfaz por las dudas se agreguen más preguntas en un futuro
        // o por si las propiedades estan mal planteadas

        private string _contenido = "Pregunta no implementada";
        public string Contenido { get => _contenido; set => _contenido = value; }
        public DateTime UltimaAparicion { get; set; }
        public int CantidadDeApariciones { get; set; }
    }
}