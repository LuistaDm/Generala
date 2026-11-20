using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BitacoraDAL
    {
        private Acceso acceso = new Acceso();
        public void Insertar(int id, string accion, DateTime fecha)
        {
            acceso.Abrir();

            List<SqlParameter> parametros = new List<SqlParameter>() {
            acceso.CrearParametro("@IdUsuario", id),
            acceso.CrearParametro("@Accion", accion),
            acceso.CrearParametro("@Fecha", fecha)
            };

            acceso.Escribir("InsertarBitacora", parametros);
            acceso.Cerrar();
        }
    }
}
