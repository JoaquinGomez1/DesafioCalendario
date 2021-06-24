using System.Collections.Generic;

namespace DesafioCalendario.Constants
{
    internal class Data
    {
        private List<string> _preguntas = new List<string>{
               "1 + 1",
               "1 + 2",
                "1 + 3" ,
                "2 * 2" ,
                "4 + 1" };

        public List<string> Preguntas { get => _preguntas; set => _preguntas = value; }
    }
}