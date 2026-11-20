using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormResultado : Form
    {
        public bool RevanchaSolicitada { get; set; }
        public string NombreJugador1 { get; set; }
        public string NombreJugador2 { get; set; }
        public FormResultado()
        {
            InitializeComponent();
        }
        public FormResultado(string nombreJugador1, int puntajeJugador1, string nombreJugador2, int puntajeJugador2, string nombreGanador, bool esEmpate)
        {
            NombreJugador1 = nombreJugador1;
            NombreJugador2 = nombreJugador2;
            RevanchaSolicitada = false;

            InitializeComponent();

            lbNombre1.Text = nombreJugador1;
            lbPuntaje1.Text = puntajeJugador1 + " puntos";

            lbNombre2.Text = nombreJugador2;
            lbPuntaje2.Text = puntajeJugador2 + " puntos";

            if (esEmpate)
            {
                lbGanador.Text = "¡La partida terminó en empate!";
            }
            else
            {
                lbGanador.Text = "¡Ganó " + nombreGanador + "!";
            }
        }
        private void btnRevancha_Click(object sender, EventArgs e)
        {
            RevanchaSolicitada = true;
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            RevanchaSolicitada = false;
            this.Close();
        }
    }
}
