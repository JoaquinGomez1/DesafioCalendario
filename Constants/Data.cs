using System.Collections.Generic;

namespace DesafioCalendario.Constants
{
    internal class Data
    {
        private List<string> _preguntas = new List<string>{
               "1 + 1",
                "18.5 + 0.5",
        };

        public List<string> Preguntas { get => _preguntas; set => _preguntas = value; }
    }
}