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
            int cantidadSemanas = 36;
            Calendario calendario = new Calendario(preguntas, cantidadSemanas);

            calendario.DebugTrucho();
            List<string> preguntasCalendarizadas = calendario.CalendarizarPreguntas();
            preguntasCalendarizadas.ForEach((each) => System.Console.WriteLine(each));
        }
    }
}