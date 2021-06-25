using DesafioCalendario.Models;
using System;
using System.Collections.Generic;

namespace DesafioCalendario.libs
{
    // Me debería retornar un listado de preguntas con su fecha y hora
    internal class Calendario
    {
        private readonly List<string> _preguntas;

        private readonly int _cantSemanas;

        // La fecha es opcional, si no se pasa ninguna se utiliza la fecha actual
        // Como el cliente en este caso era un producto interno de la empresa el formato de la fecha es el mismo que el del sistema
        private readonly string fechaLocal; // Fecha de inicio de la cantidad de semanas

        public Calendario(List<string> preguntas, int cantidadDeSemanas, string? fecha = null)
        {
            _preguntas = preguntas;
            _cantSemanas = cantidadDeSemanas;
            fechaLocal = fecha ?? DateTime.Now.ToShortDateString();
        }

        public string GetPregunta()
        {
            int randomIndex = new Random().Next(_preguntas.Count - 1);
            return _preguntas[randomIndex];
        }

        public bool EsFinDeSemana(string fecha)
        {
            DateTime nombreDelDia = DateTime.Parse(fecha);
            bool esSabado = nombreDelDia.DayOfWeek == DayOfWeek.Saturday;
            bool esDomingo = nombreDelDia.DayOfWeek == DayOfWeek.Sunday;

            return esSabado || esDomingo;
        }

        public void MostrarPregunta() => Console.WriteLine(this.GetPregunta());

        public void DebugTrucho()
        {
            string fechaDePrueba = "28/06/2021";
            Console.WriteLine($"fechaLocal: {fechaLocal}");
            Console.WriteLine($"_cantSemanas: {_cantSemanas}");
            Console.WriteLine($"Es fin de semana: {EsFinDeSemana(fechaDePrueba)}");
        }
    }
}