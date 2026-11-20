using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Presentacion
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contrasena = tbPass.Text;
            string confirmarContrasena = tbConfirmarPass.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena) || string.IsNullOrWhiteSpace(confirmarContrasena))
            {
                MessageBox.Show("Completá todos los campos.");
                return;
            }

            if (contrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            Usuario nuevoUsuario = new Usuario(usuario, contrasena);
            GestorUsuario gestorUsuario = new GestorUsuario();
            int resultado = gestorUsuario.Insertar(nuevoUsuario);

            if (resultado == 1)
            {
                Usuario usuarioRegistrado = gestorUsuario.Validar(usuario, contrasena);

                GestorBitacora gestorBitacora = new GestorBitacora();

                gestorBitacora.RegistrarAccion (usuarioRegistrado.IdUsuario, "Registro de usuario");

                MessageBox.Show("¡Usuario registrado correctamente!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (resultado == 0)
            {
                MessageBox.Show("Ese nombre de usuario ya existe.");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al registrar el usuario.");
            }
        }
    }
}
