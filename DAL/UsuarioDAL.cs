using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;

namespace DAL
{
    public class UsuarioDAL
    {
        private Acceso acceso = new Acceso();       
        public int Insertar(Usuario usuario)
        {
            acceso.Abrir();

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
            acceso.CrearParametro("@usu", usuario.Nombre),
            acceso.CrearParametro("@pass", usuario.Password)
            };
            int resultado = acceso.Escribir("InsertarUsuario", parametros);
            acceso.Cerrar();
            return resultado;
        }

        public Usuario Validar (string nombre, string password)
        {
            acceso.Abrir();

            Usuario usuario = null;
            
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                acceso.CrearParametro("@usu", nombre),
                acceso.CrearParametro("@pass", password),
            };

            SqlDataReader reader = acceso.Leer("ValidarUsuario", parametros);

            if (reader.Read()) 
            {
                int id = reader.GetInt32(0);
                string nombreUsuario = reader.GetString(1);

                usuario = new Usuario(id, nombreUsuario, password);
            }
            reader.Close();

            acceso.Cerrar();
            return usuario;
        }
        public List<Usuario> ListarTodos()
        {
            acceso.Abrir();

            List<Usuario> usuarios = new List<Usuario>();
            SqlDataReader reader = acceso.Leer("ListarUsuarios");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                Usuario usuario = new Usuario(id, nombre, "");
                usuarios.Add(usuario);
            }
            reader.Close();
            acceso.Cerrar();
            return usuarios;
        }
    }
}
