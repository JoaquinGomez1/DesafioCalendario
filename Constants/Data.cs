using DesafioCalendario.Models;
using System.Collections.Generic;

namespace DesafioCalendario.Constants
{
    internal class Data
    {
        private List<IPregunta> _preguntas = new List<IPregunta>{
               new Pregunta {Contenido = "1 + 1"},
                new Pregunta {Contenido = "1 + 2"},
                new Pregunta { Contenido = "1 + 3" },
                new Pregunta { Contenido = "2 * 2" },
                new Pregunta { Contenido = "4 + 1" } };

        public List<IPregunta> Preguntas { get => _preguntas; set => _preguntas = value; }
    }
}