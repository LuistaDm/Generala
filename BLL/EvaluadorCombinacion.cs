using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class EvaluadorCombinacion
    {
        public bool EsCombinacionValida(TipoCategoria categoria, int[] dados)
        {
            switch (categoria)
            {
                case TipoCategoria.Escalera:
                    return dados.Distinct().Count() == 5 && //Cuenta cuantos dados son distintos
                           (dados.OrderBy(x => x).SequenceEqual(new int[] { 1, 2, 3, 4, 5 }) || //Comprueba si los valores dados son iguales a uns secuencia determinada
                            dados.OrderBy(x => x).SequenceEqual(new int[] { 2, 3, 4, 5, 6 }));

                case TipoCategoria.Full:
                    return dados.GroupBy(x => x).Any(grupo => grupo.Count() == 3) && //grupo es un IEnumerable que devuelve GroupBy
                           dados.GroupBy(x => x).Any(grupo => grupo.Count() == 2);

                case TipoCategoria.Poker:
                    return dados.GroupBy(x => x).Any(grupo => grupo.Count() == 4);

                case TipoCategoria.Generala:
                case TipoCategoria.DobleGenerala:
                    return dados.Distinct().Count() == 1;

                default:
                    return dados.Length == 5;
            }
        }
    }
}
