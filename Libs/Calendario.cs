using DesafioCalendario.Models;
using System;
using System.Collections.Generic;

namespace DesafioCalendario.libs
{
    internal class Calendario
    {
        private readonly List<IPregunta> _preguntas;

        private readonly int _cantSemanas;

        public Calendario(List<IPregunta> preguntas, int cantidadDeSemanas)
        {
            _preguntas = preguntas;
            _cantSemanas = cantidadDeSemanas;
        }

        public IPregunta GetPregunta()
        {
            int randomIndex = new Random().Next(_preguntas.Count - 1);
            return _preguntas[randomIndex];
        }
    }
}