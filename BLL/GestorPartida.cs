using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class GestorPartida
    {
        public Partida Partida { get;  set; }
        private CategoriaPartidaDAL categoriaDAL = new CategoriaPartidaDAL();
        private PartidaDAL partidaDAL = new PartidaDAL();
        private CrearXML CreadorXML = new CrearXML();
        private EvaluadorCombinacion evaluador;
        private CalculadorPuntaje calculador;
        public GestorPartida(Usuario usuario1, Usuario usuario2)
        {
            Jugador jugador1 = new Jugador(usuario1.IdUsuario, usuario1.Nombre);
            Jugador jugador2 = new Jugador(usuario2.IdUsuario, usuario2.Nombre);
            Partida = new Partida(jugador1, jugador2);
            RegistrarMovimiento("InicioPartida");
            evaluador = new EvaluadorCombinacion();
            calculador = new CalculadorPuntaje();
        }
        public bool LanzarDados()
        {
            if (Partida.Estado != "EnCurso") return false;
            if (Partida.TiradaActual.CantidadLanzamientos >= 3) return false;
            Partida.TiradaActual.LanzarDados();
            RegistrarMovimiento("Lanzamiento");
            return true;
        }
        public void CambiarTurno()
        {
            if (Partida.Estado != "EnCurso") return;
            RegistrarMovimiento("CambioTurno");
            Partida.CambiarTurno();
        }
        public bool AnotarCategoria(TipoCategoria tipo)
        {
            if (Partida.Estado != "EnCurso") //Para verificar que la partida este en curso
            {
                return false;
            }

            Tirada tirada = Partida.TiradaActual; //Se extrae la tirada actual de la partida para trabajar con ella

            if (tirada.CantidadLanzamientos == 0) //Para intentar anotar algo minimamente debe haber una lanzada de dados
            {
                return false;
            }

            Categoria categoria = null; //se instancia una categoria para utilizarla

            foreach (Categoria cat in Partida.JugadorActual.Categorias) //Busca la categoria que se quiere anotar en el listado de categorias del jugador actual para utilizarla
            {
                if (cat.Tipo == tipo)
                {
                    categoria = cat;
                    break;
                }
            }

            if (categoria == null || categoria.Utilizada) //Si esta utilizada la categoria o no existe, no se puede anotar
            {
                return false;
            }

           bool tieneGenerala = Partida.JugadorActual.Categorias.Any(cat => cat.Tipo == TipoCategoria.Generala && cat.Utilizada);

            bool TacharDobleGenerala = tipo == TipoCategoria.DobleGenerala && !tieneGenerala;

            if (TacharDobleGenerala && tirada.CantidadLanzamientos < 3)
            {
                return false;
            }

            int[] dados = tirada.Dados.Select(dado => dado.Valor).ToArray(); //extrae la prop valor de cada objeto

            bool esTercerLanzamiento = tirada.CantidadLanzamientos == 3;
            bool esCategoriaNumerica = tipo >= TipoCategoria.Uno && tipo <= TipoCategoria.Seis; //Devuelve true si tipo esta entre uno y seis

            if (esCategoriaNumerica && !esTercerLanzamiento)
            {
                int valorBuscado = (int)tipo + 1; //como el array empieza desde 0 se le suma 1 para que coincida con el valor del dado

                if (!dados.Any(d => d == valorBuscado)) //Comprueba que el valor buscado este dentro de los dados lanzados
                {
                    return false;
                }
            }

            bool combinacionValida = evaluador.EsCombinacionValida(tipo, dados); //Comprueba la combinacion para las cat especiales

            if (!esCategoriaNumerica && !combinacionValida && !esTercerLanzamiento)
            {
                return false;
            }

            bool servida = tirada.CantidadLanzamientos == 1;

            int puntos = 0;

            if (!TacharDobleGenerala && (esCategoriaNumerica || combinacionValida))
            {
                puntos = calculador.CalcularPuntos(tipo, dados, servida); //calcula la tirada valida
            }

            categoria.Puntos = puntos;
            categoria.Utilizada = true;
            RegistrarMovimiento("Anotacion", tipo.ToString(), puntos);

            if (tipo == TipoCategoria.Generala && combinacionValida && servida)//La Generala servida da la victoria inmediata
            {
                Partida.Estado = "Finalizada";
                Partida.Ganador = Partida.JugadorActual;
                Partida.EsEmpate = false;
                Partida.FechaFin = DateTime.Now;
                RegistrarResultado();
                return true;
            }

            if (TodosCompletaronCategorias())
            {
                Partida.FinalizarPartida();
                RegistrarResultado();
                return true;
            }

            CambiarTurno();
            return true;
        }
        private bool TodosCompletaronCategorias()
        {
            bool jugador1Completo = Partida.Jugador1.Categorias.All(c => c.Utilizada);

            bool jugador2Completo = Partida.Jugador2.Categorias.All(c => c.Utilizada);

            return jugador1Completo && jugador2Completo;
        }
        public int GuardarPartida()
        {
            return partidaDAL.Insertar(Partida);
        }
        public void GuardarCategorias(int idPartida)
        {
            foreach (Categoria categoria in Partida.Jugador1.Categorias)
            {
                categoriaDAL.Insertar (idPartida, Partida.Jugador1.IdUsuario, categoria);
            }
            foreach (Categoria categoria in Partida.Jugador2.Categorias)
            {
                categoriaDAL.Insertar (idPartida, Partida.Jugador2.IdUsuario, categoria);
            }
        }
        public void GuardarHistorialXML(int idPartida)
        {
            CreadorXML.Guardar(Partida, idPartida);
        }
        public void AbandonarPartida()
        {
            if (Partida.Estado != "EnCurso") return;

            Partida.AbandonarPartida();
            RegistrarResultado();
        }
        private void RegistrarMovimiento(string tipoMovimiento, string categoria = null, int puntos = 0)
        {
            MovimientoPartida movimiento = new MovimientoPartida();
            movimiento.NumeroMovimiento = Partida.HistorialMovimientos.Count + 1;
            movimiento.Jugador = Partida.JugadorActual.NombreUsuario;
            movimiento.TipoMovimiento = tipoMovimiento;
            movimiento.FechaHora = DateTime.Now;
            if (tipoMovimiento == "Lanzamiento")
            {
                movimiento.ValoresDados = Partida.TiradaActual.Dados.Select(dado => dado.Valor).ToArray();
                movimiento.DadosConservados = Partida.TiradaActual.Dados.Select(dado => dado.Conservado).ToArray();
            }
            if (tipoMovimiento == "Anotacion")
            {
                movimiento.CategoriaAnotada = categoria;
                movimiento.PuntosObtenidos = puntos;
            }
            Partida.HistorialMovimientos.Add(movimiento);
        }
        private void RegistrarResultado()
        {
            RegistrarMovimiento("Finalizacion");
            MovimientoPartida movimiento = Partida.HistorialMovimientos.Last();
            movimiento.EstadoPartida = Partida.Estado;
            if (Partida.Ganador != null)
            {
                movimiento.Ganador = Partida.Ganador.NombreUsuario;
            }
            else
            {
                movimiento.Ganador = "Sin ganador";
            }
        }
    }
}
