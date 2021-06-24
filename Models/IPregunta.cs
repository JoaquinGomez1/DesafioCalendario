using System;

namespace DesafioCalendario.Models
{
    internal interface IPregunta
    {
        public string Contenido { get; set; }
        public DateTime UltimaAparicion { get; set; }
        public int CantidadDeApariciones { get; set; }
    }
}