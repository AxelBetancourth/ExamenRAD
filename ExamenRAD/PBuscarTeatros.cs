using CapaDatos.BaseDatos.Modelos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRAD
{
    public partial class PBuscarTeatros : Form
    {
        private NTeatros nTeatros;

        public int TeatroId { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Estado { get; set; }
        public PBuscarTeatros()
        {
            InitializeComponent();
            nTeatros = new NTeatros();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var datos = nTeatros.MostrarTeatros();
            dgTeatros.DataSource = datos;
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgTeatros.DataSource = nTeatros.TeatrosActivos();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void dgTeatros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TeatroId = Convert.ToInt32(dgTeatros.CurrentRow.Cells["TeatroId"].Value);
            Nombre = dgTeatros.CurrentRow.Cells["Nombre"].Value.ToString();
            this.Visible = false;
        }

        private void PBuscarTeatros_Load(object sender, EventArgs e)
        {

        }
    }
}
