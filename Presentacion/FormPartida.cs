using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace Presentacion
{
    public partial class FormPartida : Form
    {
        private Usuario jugador1;
        private Usuario jugador2;
        private GestorPartida gestorPartida;
        private GestorBitacora gestorBitacora = new GestorBitacora();
        private Image[] imagenesDados;
        private Image imagenDadoBase;
        public FormPartida(Usuario jugador1, Usuario jugador2)
        {
            InitializeComponent();
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            gestorPartida = new GestorPartida(jugador1, jugador2);
            ConfigurarGrilla();
            ActualizarPuntajes();
            ActualizarTurno();
            imagenesDados = new Image[7];
            for (int i = 1; i <= 6; i++)
            {
                imagenesDados[i] = Image.FromFile("IMG\\Dado" + i + ".png");
                imagenDadoBase = Image.FromFile("IMG\\Dado.png");
            }
            RestablecerDadosVisuales();
        }
        private void ActualizarPuntajes()
        {
            Jugador jugador1 = gestorPartida.Partida.Jugador1;
            Jugador jugador2 = gestorPartida.Partida.Jugador2;

            for (int i = 0; i < jugador1.Categorias.Count; i++)
            {
                Categoria categoria1 = jugador1.Categorias[i];
                Categoria categoria2 = jugador2.Categorias[i];

                dgvPuntajes.Rows[i].Cells[1].Value = categoria1.Utilizada ? categoria1.Puntos.ToString() : "-";
                dgvPuntajes.Rows[i].Cells[2].Value = categoria2.Utilizada ? categoria2.Puntos.ToString() : "-";
            }
            dgvPuntajes.Rows[11].Cells[1].Value = jugador1.CalcularPuntajeTotal();

            dgvPuntajes.Rows[11].Cells[2].Value = jugador2.CalcularPuntajeTotal();
        }
        private void ActualizarTurno()
        {
            LbTurnero.Text = "Turno de: " + gestorPartida.Partida.JugadorActual.NombreUsuario;
        }
        private void CambiarSeleccionDado(Button boton, int indice)
        {
            Tirada tirada = gestorPartida.Partida.TiradaActual;
            if (tirada.CantidadLanzamientos == 0 || tirada.CantidadLanzamientos >= 3)
            {
                return;
            }
            Dado dado = tirada.Dados[indice];
            dado.Conservado = !dado.Conservado;
            if (dado.Conservado)
            {
                boton.FlatAppearance.BorderColor = Color.Blue;
                boton.FlatAppearance.BorderSize = 2;
            }
            else
            {
                boton.FlatAppearance.BorderColor = Color.Gray;
                boton.FlatAppearance.BorderSize = 2;
            }
        }
        private void ActualizarContador()
        {
            int cantidad = gestorPartida.Partida.TiradaActual.CantidadLanzamientos;

            LbContador.Text = "Lanzamientos: " + cantidad + "/3";
        }
        private void MostrarResultado()
        {
            Partida partida = gestorPartida.Partida;

            gestorBitacora.RegistrarAccion (jugador1.IdUsuario, "Finalización de partida");

            int idPartida = gestorPartida.GuardarPartida();
            if (idPartida == -1)
            {
                MessageBox.Show("No se pudo guardar la partida.");
                return;
            }

            gestorPartida.GuardarCategorias(idPartida);
            gestorPartida.GuardarHistorialXML(idPartida);
            string nombreGanador = "";
            if (partida.Ganador != null)
            {
                nombreGanador = partida.Ganador.NombreUsuario;
            }
            FormResultado resultado = new FormResultado(
                partida.Jugador1.NombreUsuario,
                partida.Jugador1.CalcularPuntajeTotal(),
                partida.Jugador2.NombreUsuario,
                partida.Jugador2.CalcularPuntajeTotal(),
                nombreGanador,
                partida.EsEmpate
            );
            resultado.ShowDialog();
            if (resultado.RevanchaSolicitada)
            {
                FormPartida revancha = new FormPartida(
                    jugador1, 
                    jugador2
                );
                this.Hide();
                revancha.ShowDialog();
            }
            this.Close();
        }
        private void btnDado1_Click(object sender, EventArgs e)
        {
            CambiarSeleccionDado(btnDado1, 0);
        }
        private void btnDado2_Click(object sender, EventArgs e)
        {
            CambiarSeleccionDado(btnDado2, 1);
        }
        private void btnDado3_Click(object sender, EventArgs e)
        {
            CambiarSeleccionDado(btnDado3, 2);
        }
        private void btnDado4_Click(object sender, EventArgs e)
        {
            CambiarSeleccionDado(btnDado4, 3);
        }
        private void btnDado5_Click(object sender, EventArgs e)
        {
            CambiarSeleccionDado(btnDado5, 4);
        }
        private void ActualizarImagenesDados()
        {
            Button[] botones =
            {
                btnDado1,
                btnDado2,
                btnDado3,
                btnDado4,
                btnDado5
            };
            Tirada tirada = gestorPartida.Partida.TiradaActual;
            for (int i = 0; i < 5; i++)
            {
                int valor = tirada.Dados[i].Valor;
                botones[i].BackgroundImage = imagenesDados[valor];
            }
        }
        private void RestablecerDadosVisuales()
        {
            Button[] botones =
            {
                btnDado1,
                btnDado2,
                btnDado3,
                btnDado4,
                btnDado5
             };

            foreach (Button boton in botones)
            {
                boton.BackgroundImage = imagenDadoBase;
                boton.FlatAppearance.BorderColor = Color.Gray;
            }
        }
        private void btnLanzarDados_Click(object sender, EventArgs e)
        {
            bool lanzamientoRealizado = gestorPartida.LanzarDados();
            if (!lanzamientoRealizado)
            {
                MessageBox.Show("No se pueden realizar más lanzamientos.");
                return;
            }
            ActualizarImagenesDados();
            ActualizarContador();
        }
        private void ConfigurarGrilla()
        {
            dgvPuntajes.Columns.Clear();
            dgvPuntajes.Rows.Clear();

            dgvPuntajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPuntajes.RowHeadersVisible = false;

            dgvPuntajes.Columns.Add("Categoria", "Categoría");
            dgvPuntajes.Columns.Add("Jugador1", "Jugador 1");
            dgvPuntajes.Columns.Add("Jugador2", "Jugador 2");

            string[] categorias =
            {
                "Uno",
                "Dos",
                "Tres",
                "Cuatro",
                "Cinco",
                "Seis",
                "Escalera",
                "Full",
                "Póker",
                "Generala",
                "Doble Generala"
             };

            foreach (string categoria in categorias)
            {
                dgvPuntajes.Rows.Add(categoria, "-", "-");
            }

            dgvPuntajes.Rows.Add("TOTAL", "0", "0");
            dgvPuntajes.Columns[1].HeaderText = gestorPartida.Partida.Jugador1.NombreUsuario;
            dgvPuntajes.Columns[2].HeaderText = gestorPartida.Partida.Jugador2.NombreUsuario;
        }
        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (dgvPuntajes.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una categoría.");
                return;
            }
            int indice = dgvPuntajes.SelectedRows[0].Index;
            if (indice == 11)
            {
                MessageBox.Show("Seleccioná una categoría válida.");
                return;
            }
            TipoCategoria tipo = (TipoCategoria)indice;
            bool anotacionCorrecta = gestorPartida.AnotarCategoria(tipo);
            if (!anotacionCorrecta)
            {
                MessageBox.Show("No podés anotar esa categoría con los dados actuales.");
                return;
            }
            ActualizarPuntajes();
            ActualizarContador();

            if (gestorPartida.Partida.Estado != "EnCurso")
            {
                MostrarResultado();
                return;
            }
            ActualizarTurno();
            RestablecerDadosVisuales();
            MessageBox.Show("Categoría anotada correctamente");
        }
        private void btnAbandonar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estás seguro de que querés abandonar la partida?", "Abandonar partida", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                gestorPartida.AbandonarPartida();
                MostrarResultado();
                this.Close();
            }
        }
    }
}
