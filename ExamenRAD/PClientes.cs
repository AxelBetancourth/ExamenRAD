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
    public partial class PClientes : Form
    {
        private NClientes nClientes;
        private NReserva nReserva;

        public PClientes()
        {
            InitializeComponent();
            nClientes = new NClientes();
            nReserva = new NReserva();
            CargarDatos();
        }

        private void PClientes_Load(object sender, EventArgs e)
        {

        }

        void CargarDatos()
        {
            dgClientes.DataSource = nClientes.MostrarClientes();
        }

        void LimpiarDatos()
        {
            txtClienteId.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgClientes.DataSource = nClientes.ClientesActivos();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtNombres.Text.ToString()) || string.IsNullOrWhiteSpace(txtNombres.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtNombres, "Debe ingresar un Nombre");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtApellidos.Text.ToString()) || string.IsNullOrWhiteSpace(txtApellidos.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtApellidos, "Debe ingresar un Apellido");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var fecha = dtpFechaIngreso.Value.ToString();
            DateTime fechaeditarCliente = DateTime.Parse(fecha);

            if (ValidarDatos())
            {
                Clientes clientes = new Clientes()

                {
                    Nombres = txtNombres.Text.ToString(),
                    Apellidos = txtApellidos.Text.ToString(),
                    FechaIngreso = fechaeditarCliente,
                    Estado = cbEstado.Checked,
                };
                if (!string.IsNullOrEmpty(txtClienteId.Text) && int.TryParse(txtClienteId.Text.ToString(), out int clienteId) && clienteId != 0)
                {
                    clientes.ClienteId = clienteId;
                    nClientes.EditarClientes(clientes);
                }
                else
                {
                    nClientes.AgregarClientes(clientes);
                }
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var clienteId = txtClienteId.Text.ToString();
            if (string.IsNullOrEmpty(clienteId) || string.IsNullOrWhiteSpace(clienteId))
            {
                return;
            }
            var ReservasAsociadas = nReserva.MostrarReserva().Where(c => c.ClienteId == int.Parse(clienteId)).ToList();
            if (ReservasAsociadas.Count > 0)
            {
                MessageBox.Show("El cliente esta asociado a 'Reservas', desvinculelo para poder eliminar ");
            }
            else
            {
                nClientes.EliminarClientes(int.Parse(clienteId));
                CargarDatos();
                LimpiarDatos();
            }
        }

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgClientes.Rows.Count)
            {
                DataGridViewRow row = dgClientes.Rows[e.RowIndex];
                txtClienteId.Text = row.Cells["ClienteId"].Value.ToString();
                txtNombres.Text = row.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                if (DateTime.TryParse(dgClientes.CurrentRow.Cells["FechaIngreso"].Value.ToString(), out DateTime fechaIngreso))
                {
                    dtpFechaIngreso.Value = fechaIngreso;
                }
                cbEstado.Checked = bool.Parse(dgClientes.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }
    }
}
