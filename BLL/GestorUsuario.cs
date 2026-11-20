using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorUsuario
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();
        public int Insertar(Usuario usuario)
        {
            return usuarioDAL.Insertar(usuario);
        }
        public Usuario Validar(string nombre, string password)
        {
            return usuarioDAL.Validar(nombre, password);
        }
        public List<Usuario> ListarTodos()
        {
            return usuarioDAL.ListarTodos();
        }
    }
}
