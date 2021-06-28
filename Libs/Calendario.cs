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

        public readonly List<string> _calendario = new List<string> { };
        private readonly Random random = new Random();

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

        public TimeSpan GenerarHorarioRandom(int minimo, int maximo)
        {
            TimeSpan horaInicial = TimeSpan.FromHours(minimo);
            TimeSpan horaFinal = TimeSpan.FromHours(maximo);

            // Calcula la cantidad de minutos que hay en esa franja horaria
            int maximoMinutos = (int)((horaFinal - horaInicial).TotalMinutes);

            // Y luego genera un numero aleatorio de minutos a agregar a la hora inicial
            int minutes = random.Next(maximoMinutos);
            TimeSpan horarioRandom = horaInicial.Add(TimeSpan.FromMinutes(minutes));
            return horarioRandom;
        }

        public DateTime GenerarDiaLaboralRandom(string fechaInicio)
        {
            DateTime fechaInicial = DateTime.Parse(fechaInicio);
            DateTime fechaFinal = fechaInicial.AddDays(5);
            int rangoDeDias = (fechaFinal - fechaInicial).Days;
            int cantRandomDeDias = random.Next(rangoDeDias);

            return fechaInicial.AddDays(cantRandomDeDias);
        }

        public List<string> CalendarizarPreguntas()
        {
            // Por ahora solamente le asigna una fecha y horario a una pregunta pero no se verifica la fecha en la que esta pregunta apareció
            DateTime fechaDeInicio = DateTime.Parse(fechaLocal);
            for (int i = 0; i < _cantSemanas; i++)
            {
                string preguntaLocal = GetPregunta();

                string fechaDeLaSemana = fechaDeInicio.AddDays(i * 7).ToShortDateString();
                DateTime fecha = GenerarDiaLaboralRandom(fechaDeLaSemana);
                string fechaString = fecha.ToShortDateString();
                string horario = GenerarHorarioRandom(9, 18).ToString();

                _calendario.Add($"Fecha: {fechaString}, ||  Nombre del Dia: {fecha.DayOfWeek} || Hora: {horario} || Pregunta: {preguntaLocal}");
            }

            return _calendario;
        }

        public void MostrarPregunta() => Console.WriteLine(this.GetPregunta());

        public void DebugTrucho()
        {
            string fechaDePrueba = DateTime.Now.ToShortDateString();
            Console.WriteLine($"fechaLocal: {fechaLocal}");
            Console.WriteLine($"_cantSemanas: {_cantSemanas}");
            Console.WriteLine($"Es fin de semana: {EsFinDeSemana(fechaDePrueba)}");
            Console.WriteLine($"Fecha Random: {GenerarDiaLaboralRandom(fechaDePrueba)}");
            Console.WriteLine($"Horario Random: {GenerarHorarioRandom(9, 18)}");
            Console.WriteLine("\n");
        }
    }
}