using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class MovimientoPartida
    {
        public int NumeroMovimiento { get; set; }
        public string Jugador { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime FechaHora { get; set; }
        public int[] ValoresDados { get; set; }
        public bool[] DadosConservados { get; set; }
        public string CategoriaAnotada { get; set; }
        public int PuntosObtenidos { get; set; }
        public string EstadoPartida { get; set; }
        public string Ganador { get; set; }
    }
}
