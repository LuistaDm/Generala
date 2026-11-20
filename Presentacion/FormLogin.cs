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
    public partial class FormLogin : Form
    {
        public Usuario UsuarioAutenticado { get; set; }
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contrasena = tbPass.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            GestorUsuario gestorUsuario = new GestorUsuario();
            Usuario usuarioEncontrado = gestorUsuario.Validar(usuario, contrasena);

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }
            UsuarioAutenticado = usuarioEncontrado;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
