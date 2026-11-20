using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Dado
    {
        public int Valor { get; set; }
        public bool Conservado { get; set; }
        private static Random random = new Random();
        public Dado()
        {
            Valor = 1;
            Conservado = false;
        }
        public void Lanzar()
        {
            Valor = random.Next(1, 7);
        }
    }
}
