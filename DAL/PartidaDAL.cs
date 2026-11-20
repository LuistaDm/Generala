using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PartidaDAL
    {
        private Acceso acceso = new Acceso();
        public int Insertar(Partida partida)
        {
            acceso.Abrir();

            object idGanador = DBNull.Value;
            if (partida.Ganador != null)
            {
                idGanador = partida.Ganador.IdUsuario;
            }


            List<SqlParameter> parametros = new List<SqlParameter>()
        {
            acceso.CrearParametro("@IdJugador1", partida.Jugador1.IdUsuario),
            acceso.CrearParametro("@IdJugador2", partida.Jugador2.IdUsuario),
            acceso.CrearParametro("@IdGanador", idGanador),
            acceso.CrearParametro("@FechaInicio", partida.FechaInicio),
            acceso.CrearParametro("@FechaFin", partida.FechaFin.Value),
            acceso.CrearParametro("@Estado", partida.Estado),
            acceso.CrearParametro("@Empate", partida.EsEmpate)
        };

            int idPartida = acceso.LeerEscalar("InsertarPartida", parametros);
            acceso.Cerrar();
            return idPartida;
        }
        public EstadisticasJugador ObtenerEstadisticas(int idUsuario)
        {
            acceso.Abrir();

            List<SqlParameter> parametros = new List<SqlParameter>()
        {
            acceso.CrearParametro("@IdUsuario", idUsuario)
        };

            SqlDataReader reader = acceso.Leer("ObtenerEstadisticasJugador", parametros);
            EstadisticasJugador estadisticas = new EstadisticasJugador();

            if (reader.Read())
            {
                estadisticas.PartidasGanadas = reader.GetInt32(0);
                estadisticas.PartidasPerdidas = reader.GetInt32(1);
                estadisticas.PartidasEmpatadas = reader.GetInt32(2);
                estadisticas.PromedioVictorias = reader.GetDecimal(3);

                long segundos = Convert.ToInt64(reader[4]);
                estadisticas.TiempoTotal = TimeSpan.FromSeconds(segundos);
            }
            reader.Close();
            acceso.Cerrar();
            return estadisticas;
        }
    }
}
