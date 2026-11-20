using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private Usuario usuarioActual;
        private GestorBitacora gestorBitacora = new GestorBitacora();
        public Form1()
        {
            InitializeComponent();
            usuarioActual = null;
            ActualizarUsuario();
            ActualizarEstadoBotones();
        }
        private void ActualizarUsuario()
        {
            if (usuarioActual == null)
            {
                lblUsuario.Text = "Usuario: Sin iniciar sesión";
            }
            else
            {
                lblUsuario.Text = "Usuario: " + usuarioActual.Nombre;
            }
        }
        private void ActualizarEstadoBotones()
        {
            bool haySesion = usuarioActual != null;

            btnLogin.Enabled = !haySesion;
            btnRegistrar.Enabled = !haySesion;
            btnLogout.Enabled = haySesion;
            btnIniciarPartida.Enabled = haySesion;
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("Primero tenés que iniciar sesión.");
                return;
            }
            FormLoginJugador2 formularioJugador2 = new FormLoginJugador2(usuarioActual.Nombre);

            if (formularioJugador2.ShowDialog() == DialogResult.OK)
            {
                Usuario usuarioJugador2 = formularioJugador2.UsuarioAutenticado;

                gestorBitacora.RegistrarAccion(usuarioActual.IdUsuario, "Inicio de partida");

                FormPartida partida = new FormPartida(
                    usuarioActual,
                    usuarioJugador2
                );
                partida.ShowDialog();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formularioLogin = new FormLogin();

            if (formularioLogin.ShowDialog() == DialogResult.OK)
            {
                usuarioActual = formularioLogin.UsuarioAutenticado;
                gestorBitacora.RegistrarAccion(usuarioActual.IdUsuario, "Inicio de sesión");
                ActualizarUsuario();
                ActualizarEstadoBotones();

                MessageBox.Show("¡Bienvenido/a, " + usuarioActual.Nombre + "!");
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro formularioRegistro = new FormRegistro();
            formularioRegistro.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            gestorBitacora.RegistrarAccion(usuarioActual.IdUsuario, "Cierre de sesión");
            usuarioActual = null;
            ActualizarUsuario();
            ActualizarEstadoBotones();
            MessageBox.Show("Se cerró la sesión correctamente.");
        }
        private void btnReglas_Click(object sender, EventArgs e)
        {
            FormReglas formularioReglas = new FormReglas();
            formularioReglas.ShowDialog();
        }
        private void btnMejoresJugadores_Click(object sender, EventArgs e)
        {
            FormEstadisticas formularioEstadisticas = new FormEstadisticas();
            formularioEstadisticas.ShowDialog();
        }
    }
}
