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
    public partial class PBuscarClientes : Form
    {
        private NClientes nClientes;

        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        public PBuscarClientes()
        {
            InitializeComponent();
            nClientes = new NClientes();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var datos = nClientes.MostrarClientes();
            dgClientes.DataSource = datos;
            dgClientes.Columns["Nombres"].HeaderText = "Nombre Completo";
            dgClientes.Columns["Apellidos"].Visible = false;
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgClientes.DataSource = nClientes.ClientesActivos();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteId = Convert.ToInt32(dgClientes.CurrentRow.Cells["ClienteId"].Value);
            Nombres = dgClientes.CurrentRow.Cells["Nombres"].Value.ToString();
            this.Visible = false;
        }

        private void PBuscarClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
