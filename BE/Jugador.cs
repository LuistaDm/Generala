using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Jugador
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public List<Categoria> Categorias { get; set; }
        public Jugador(int idUsuario, string nombreUsuario)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Categorias = new List<Categoria>();

            foreach (TipoCategoria tipo in Enum.GetValues(typeof(TipoCategoria)))
            {
                Categorias.Add(new Categoria(tipo));
            }
        }
        public int CalcularPuntajeTotal()
        {
            int total = 0;

            foreach (Categoria categoria in Categorias)
            {
                total += categoria.Puntos;
            }
            return total;
        }
    }
}
