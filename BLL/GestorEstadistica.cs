using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorEstadistica
    {
        private PartidaDAL partidaDAL = new PartidaDAL();
        public EstadisticasJugador ObtenerEstadisticas(int idUsuario)
        {
            return partidaDAL.ObtenerEstadisticas(idUsuario);
        }
    }
}
