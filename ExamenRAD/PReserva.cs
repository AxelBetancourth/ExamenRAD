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
    public partial class PReserva : Form
    {
        private NReserva nReserva;
        public PReserva()
        {
            InitializeComponent();
            nReserva = new NReserva();
        }

        private void PReserva_Load(object sender, EventArgs e)
        {

        }
        void CargarDatos()
        {
            dgReserva.DataSource = nReserva.MostrarReserva();
        }

        void LimpiarDatos()
        {
            txtReservaId.Text = "";
            txtClienteId.Text = "";
            txtNombreCliente.Text = "";
            txtTeatroId.Text = "";
            txtNombreTeatro.Text = "";
            errorProvider1.Clear();
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtNombreCliente.Text.ToString()) || string.IsNullOrWhiteSpace(txtNombreCliente.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtNombreCliente, "Debe ingresar un Cliente");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtNombreTeatro.Text.ToString()) || string.IsNullOrWhiteSpace(txtNombreTeatro.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtNombreTeatro, "Debe ingresar un Teatro");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var fecha = dtpFechaReserva.Value.ToString();
            DateTime fechaeditarReserva = DateTime.Parse(fecha);

            if (ValidarDatos())
            {
                Reserva reserva = new Reserva()
                {
                    ClienteId = int.Parse(txtClienteId.Text.ToString()),
                    TeatroId = int.Parse(txtTeatroId.Text.ToString()),
                    FechaReserva = fechaeditarReserva,
                };
                if (!string.IsNullOrEmpty(txtReservaId.Text) && int.TryParse(txtReservaId.Text.ToString(), out int reservaId) && reservaId != 0)
                {
                    reserva.ReservaId = reservaId;
                    nReserva.EditarReserva(reserva);
                }
                else
                {
                    nReserva.AgregarReserva(reserva);
                }
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var reservaId = txtReservaId.Text.ToString();
            if (string.IsNullOrEmpty(reservaId) || string.IsNullOrWhiteSpace(reservaId))
            {
                return;
            }
            nReserva.EliminarReserva(int.Parse(reservaId));
            CargarDatos();
            LimpiarDatos();
        }

        private void dgReserva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgReserva.Rows.Count)
            {
                txtReservaId.Text = dgReserva.CurrentRow.Cells["ReservaId"].Value.ToString();
                txtClienteId.Text = dgReserva.CurrentRow.Cells["ClienteId"].Value.ToString();
                txtNombreCliente.Text = dgReserva.CurrentRow.Cells["NombreClientes"].Value.ToString();
                txtTeatroId.Text = dgReserva.CurrentRow.Cells["TeatroId"].Value.ToString();
                txtNombreTeatro.Text = dgReserva.CurrentRow.Cells["NombreTeatro"].Value.ToString();
                if (DateTime.TryParse(dgReserva.CurrentRow.Cells["FechaReserva"].Value.ToString(), out DateTime fechaReserva))
                {
                    dtpFechaReserva.Value = fechaReserva;
                }
            }
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            PBuscarClientes BuscarClientes = new PBuscarClientes();
            BuscarClientes.ShowDialog();
            txtClienteId.Text = BuscarClientes.ClienteId.ToString(); ;
            txtNombreCliente.Text = BuscarClientes.Nombres.ToString();
        }

        private void bTeatros_Click(object sender, EventArgs e)
        {
            PBuscarTeatros BuscarTeatros = new PBuscarTeatros();
            BuscarTeatros.ShowDialog();
            txtTeatroId.Text = BuscarTeatros.TeatroId.ToString(); ;
            txtNombreTeatro.Text = BuscarTeatros.Nombre.ToString();
        }
    }
}
