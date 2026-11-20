using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaPartidaDAL
    {
        private Acceso acceso = new Acceso();

        public void Insertar(int idPartida, int idUsuario, Categoria categoria)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>()
        {
            acceso.CrearParametro("@IdPartida", idPartida),
            acceso.CrearParametro("@IdUsuario", idUsuario),
            acceso.CrearParametro("@TipoCategoria", categoria.Tipo.ToString()),
            acceso.CrearParametro("@Puntos", categoria.Puntos),
            acceso.CrearParametro("@Utilizada", categoria.Utilizada)
        };

            acceso.Escribir("InsertarCategoriaPartida", parametros);
            acceso.Cerrar();
        }
    }
}
