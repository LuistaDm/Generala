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
    public partial class FormEstadisticas : Form
    {
        private GestorUsuario gestorUsuario = new GestorUsuario();
        private GestorEstadistica gestorEstadisticas = new GestorEstadistica();

        public FormEstadisticas()
        {
            InitializeComponent();
            CargarUsuarios();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = gestorUsuario.ListarTodos();
            dgvUsuarios.Columns["IdUsuario"].Visible = false;
            dgvUsuarios.Columns["Password"].Visible = false;
        }
        private void CargarEstadisticas(int idUsuario)
        {
            EstadisticasJugador estadisticas = gestorEstadisticas.ObtenerEstadisticas(idUsuario);

            dgvEstadisticas.Rows.Clear();

            dgvEstadisticas.Rows.Add("Partidas ganadas", estadisticas.PartidasGanadas);
            dgvEstadisticas.Rows.Add("Partidas perdidas", estadisticas.PartidasPerdidas);
            dgvEstadisticas.Rows.Add("Partidas empatadas", estadisticas.PartidasEmpatadas);
            dgvEstadisticas.Rows.Add("Promedio de victorias", estadisticas.PromedioVictorias.ToString("0.00") + "%");
            dgvEstadisticas.Rows.Add("Tiempo total jugado", estadisticas.TiempoTotal);
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
                CargarEstadisticas(idUsuario);
            }
        }
    }
}
