using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Partida
    {
        public Jugador Jugador1 { get; set; }
        public Jugador Jugador2 { get; set; }
        public Jugador JugadorActual { get; set; }
        public Tirada TiradaActual { get; set; }
        public string Estado { get; set; }
        public Jugador Ganador { get; set; }
        public bool EsEmpate { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public List<MovimientoPartida> HistorialMovimientos { get; set; }
        public Partida(Jugador jugador1, Jugador jugador2)
        {
            Jugador1 = jugador1;
            Jugador2 = jugador2;

            JugadorActual = jugador1;
            TiradaActual = new Tirada();

            Estado = "EnCurso";
            Ganador = null;
            EsEmpate = false;

            FechaInicio = DateTime.Now;
            FechaFin = null;

            HistorialMovimientos = new List<MovimientoPartida>();
        }
        public void CambiarTurno()
        {
            if (JugadorActual == Jugador1)
            {
                JugadorActual = Jugador2;
            }
            else
            {
                JugadorActual = Jugador1;
            }

            TiradaActual.ReiniciarTurno();
        }
        public void FinalizarPartida()
        {
            Estado = "Finalizada";
            FechaFin = DateTime.Now;

            int puntaje1 = Jugador1.CalcularPuntajeTotal();
            int puntaje2 = Jugador2.CalcularPuntajeTotal();

            if (puntaje1 > puntaje2)
            {
                Ganador = Jugador1;
            }
            else if (puntaje2 > puntaje1)
            {
                Ganador = Jugador2;
            }
            else
            {
                Ganador = null;
                EsEmpate = true;
            }
        }
        public void AbandonarPartida()
        {
            Estado = "Abandonada";
            FechaFin = DateTime.Now;

            if (JugadorActual == Jugador1)
            {
                Ganador = Jugador2;
            }
            else
            {
                Ganador = Jugador1;
            }

            EsEmpate = false;
        }
    }
}
