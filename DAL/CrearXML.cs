using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class CrearXML
    {

        public void Guardar(Partida partida, int idPartida)
        {
            DataSet ds = new DataSet("Partida");

            DataTable tablaPartida = new DataTable("DatosPartida");

            tablaPartida.Columns.Add("IdPartida");
            tablaPartida.Columns.Add("Jugador1");
            tablaPartida.Columns.Add("Jugador2");
            tablaPartida.Columns.Add("FechaInicio");
            tablaPartida.Columns.Add("FechaFin");
            tablaPartida.Columns.Add("Estado");
            tablaPartida.Columns.Add("Ganador");

            DataRow filaPartida = tablaPartida.NewRow();

            filaPartida["IdPartida"] = idPartida;
            filaPartida["Jugador1"] = partida.Jugador1.NombreUsuario;
            filaPartida["Jugador2"] = partida.Jugador2.NombreUsuario;
            filaPartida["FechaInicio"] = partida.FechaInicio;
            if (partida.FechaFin != null)
            {
                filaPartida["FechaFin"] = partida.FechaFin.Value;
            }
            else
            {
                filaPartida["FechaFin"] = DBNull.Value;
            }

            filaPartida["Estado"] = partida.Estado;
           
            if (partida.Ganador != null)
            {
                filaPartida["Ganador"] = partida.Ganador.NombreUsuario;
            }
            else
            {
                filaPartida["Ganador"] = "Sin ganador";
            }

            tablaPartida.Rows.Add(filaPartida);

            DataTable tablaMovimientos = new DataTable("Movimientos");

            tablaMovimientos.Columns.Add("NumeroMovimiento");
            tablaMovimientos.Columns.Add("Jugador");
            tablaMovimientos.Columns.Add("TipoMovimiento");
            tablaMovimientos.Columns.Add("FechaHora");
            tablaMovimientos.Columns.Add("ValoresDados");
            tablaMovimientos.Columns.Add("DadosConservados");
            tablaMovimientos.Columns.Add("CategoriaAnotada");
            tablaMovimientos.Columns.Add("PuntosObtenidos");
            tablaMovimientos.Columns.Add("EstadoPartida");
            tablaMovimientos.Columns.Add("Ganador");

            foreach (MovimientoPartida movimiento in partida.HistorialMovimientos)
            {
                DataRow fila = tablaMovimientos.NewRow();

                fila["NumeroMovimiento"] = movimiento.NumeroMovimiento;
                fila["Jugador"] = movimiento.Jugador;
                fila["TipoMovimiento"] = movimiento.TipoMovimiento;
                fila["FechaHora"] = movimiento.FechaHora;

                if (movimiento.ValoresDados != null)
                {
                    fila["ValoresDados"] = string.Join(",", movimiento.ValoresDados);
                    fila["DadosConservados"] = string.Join(",", movimiento.DadosConservados);
                }

                if (movimiento.CategoriaAnotada != null)
                {
                    fila["CategoriaAnotada"] = movimiento.CategoriaAnotada;
                }
                else
                {
                    fila["CategoriaAnotada"] = "";
                }

                fila["PuntosObtenidos"] = movimiento.PuntosObtenidos;

                if (movimiento.EstadoPartida != null)
                {
                    fila["EstadoPartida"] = movimiento.EstadoPartida;
                }
                else
                {
                    fila["EstadoPartida"] = "";
                }

                if (movimiento.Ganador != null)
                {
                    fila["Ganador"] = movimiento.Ganador;
                }
                else
                {
                    fila["Ganador"] = "";
                }

                tablaMovimientos.Rows.Add(fila);
            }

            ds.Tables.Add(tablaPartida);
            ds.Tables.Add(tablaMovimientos);

            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HistorialPartidas");
            Directory.CreateDirectory(carpeta);
            string ruta = Path.Combine(carpeta, "Partida_" + idPartida + ".xml");
            ds.WriteXml(ruta);
        }
    }
}
