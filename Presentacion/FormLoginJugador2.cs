using BE;
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

namespace Presentacion
{
    public partial class FormLoginJugador2 : Form
    {
        private string nombreJugador1;
        public Usuario UsuarioAutenticado { get; set; }
        public FormLoginJugador2(string jugador1)
        {
            InitializeComponent();
            nombreJugador1 = jugador1;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text.Trim();
            string contraseña = tbPass.Text;
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            GestorUsuario gestorUsuario = new GestorUsuario();
            Usuario usuarioEncontrado = gestorUsuario.Validar(usuario, contraseña);

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }
            if (string.Compare(usuarioEncontrado.Nombre, nombreJugador1, true) == 0)
            {
                MessageBox.Show("El segundo jugador debe ser diferente al primero.");
                return;
            }
            UsuarioAutenticado = usuarioEncontrado;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
