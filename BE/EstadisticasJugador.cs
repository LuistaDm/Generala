using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EstadisticasJugador
    {
        public int PartidasGanadas { get; set; }
        public int PartidasPerdidas { get; set; }
        public int PartidasEmpatadas { get; set; }
        public decimal PromedioVictorias { get; set; }
        public TimeSpan TiempoTotal { get; set; }
    }
}
