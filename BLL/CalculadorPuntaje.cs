using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class CalculadorPuntaje
    {
        public int CalcularPuntos(TipoCategoria categoria, int[] dados, bool servida)
        {
            int puntos = 0;

            switch (categoria)
            {
                case TipoCategoria.Uno:
                case TipoCategoria.Dos:
                case TipoCategoria.Tres:
                case TipoCategoria.Cuatro:
                case TipoCategoria.Cinco:
                case TipoCategoria.Seis:

                    int valorBuscado = (int)categoria + 1;

                    foreach (int dado in dados)
                    {
                        if (dado == valorBuscado)
                        {
                            puntos += dado;
                        }
                    }

                    break;

                case TipoCategoria.Escalera:
                    puntos = servida ? 25 : 20;
                    break;

                case TipoCategoria.Full:
                    puntos = servida ? 35 : 30;
                    break;

                case TipoCategoria.Poker:
                    puntos = servida ? 45 : 40;
                    break;

                case TipoCategoria.Generala:
                    puntos = 50;
                    break;

                case TipoCategoria.DobleGenerala:
                    puntos = 100;
                    break;
            }

            return puntos;
        }
    }
}
