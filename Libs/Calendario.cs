using System;
using System.Collections.Generic;

namespace DesafioCalendario.libs
{
    internal class Calendario
    {
        private readonly List<string> _preguntas;

        private readonly int _cantSemanas;

        // La fecha es opcional, si no se pasa ninguna se utiliza la fecha actual
        // Como el cliente en este caso era un producto interno de la empresa el formato de la fecha es el mismo que el del sistema
        private readonly string fechaLocal;

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

        public void MostrarPregunta() => Console.WriteLine(this.GetPregunta());

        public void DebugTrucho()
        {
            Console.WriteLine($"fechaLocal: {fechaLocal}");
            Console.WriteLine($"_cantSemanas: {_cantSemanas}");
        }
    }
}