using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Categoria
    {
        public TipoCategoria Tipo { get; set; }
        public bool Utilizada { get; set; }
        public int Puntos { get; set; }
        public Categoria(TipoCategoria tipo)
        {
            Tipo = tipo;
            Utilizada = false;
            Puntos = 0;
        }
    }
}
