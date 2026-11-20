using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tirada
    {
        public List<Dado> Dados { get; private set; }
        public int CantidadLanzamientos { get; private set; }
        public Tirada()
        {
            Dados = new List<Dado>();

            for (int i = 0; i < 5; i++)
            {
                Dados.Add(new Dado());
            }
            CantidadLanzamientos = 0;
        }
        public void LanzarDados()
        {
            foreach (Dado dado in Dados)
            {
                if (!dado.Conservado)
                {
                    dado.Lanzar();
                }
            }
            CantidadLanzamientos++;
        }
        public void ReiniciarTurno()
        {
            CantidadLanzamientos = 0;

            foreach (Dado dado in Dados)
            {
                dado.Conservado = false;
            }
        }
    }
}
