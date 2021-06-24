using System;

namespace DesafioCalendario.Models
{
    internal interface IPregunta
    {
        // La idea es usar esta interfaz para mantener un formato unificado de las preguntas

        public string Contenido { get; set; }
        public DateTime UltimaAparicion { get; set; }
        public int CantidadDeApariciones { get; set; }
    }
}