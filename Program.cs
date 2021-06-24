using DesafioCalendario.Constants;
using DesafioCalendario.libs;
using DesafioCalendario.Models;
using System.Collections.Generic;

namespace DesafioCalendario
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<IPregunta> preguntas = new Data().Preguntas;
            int cantidadSemanas = 6;
            Calendario calendario = new Calendario(preguntas, cantidadSemanas);

            System.Console.WriteLine(calendario.GetPregunta().Contenido);
        }
    }
}