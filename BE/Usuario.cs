using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public Usuario(int idUsuario, string nombre, string password)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Password = password;
        }
        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }
    }
}
