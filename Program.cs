using DesafioCalendario.Constants;
using DesafioCalendario.libs;
using System.Collections.Generic;

namespace DesafioCalendario
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> preguntas = new Data().Preguntas;
            int cantidadSemanas = 6;
            Calendario calendario = new Calendario(preguntas, cantidadSemanas);

            calendario.MostrarPregunta();
            calendario.DebugTrucho();
        }
    }
}