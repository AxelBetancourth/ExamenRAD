using CapaDatos;
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
    public partial class PTeatros : Form
    {
        private NTeatros nTeatros;
        private NReserva nReserva;
        public PTeatros()
        {
            InitializeComponent();
            nTeatros = new NTeatros();
            nReserva = new NReserva();
            CargarDatos();
        }

        private void PTeatros_Load(object sender, EventArgs e)
        {

        }
        void CargarDatos()
        {
            dgTeatros.DataSource = nTeatros.MostrarTeatros();
        }

        void LimpiarDatos()
        {
            txtTeatroId.Text = "";
            txtNombre.Text = "";
            txtCapacidad.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }
        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgTeatros.DataSource = nTeatros.TeatrosActivos();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }

        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtNombre.Text.ToString()) || string.IsNullOrWhiteSpace(txtNombre.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtNombre, "Debe ingresar un Nombre");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtCapacidad.Text.ToString()) || string.IsNullOrWhiteSpace(txtCapacidad.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtCapacidad, "Debe ingresar una capacidad de personas");
                return FormularioValido;
            }
            return FormularioValido;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                Teatros teatros = new Teatros()
                {
                    Nombre = txtNombre.Text.ToString(),
                    Capacidad = int.Parse(txtCapacidad.Text.ToString()),
                    Estado = cbEstado.Checked,
                };
                if (!string.IsNullOrEmpty(txtTeatroId.Text) && int.TryParse(txtTeatroId.Text.ToString(), out int teatroId) && teatroId != 0)
                {
                    teatros.TeatroId = teatroId;
                    nTeatros.EditarTeatros(teatros);
                }
                else
                {
                    nTeatros.AgregarTeatros(teatros);
                }
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var teatroId = txtTeatroId.Text.ToString();
            if (string.IsNullOrEmpty(teatroId) || string.IsNullOrWhiteSpace(teatroId))
            {
                return;
            }
            var ReservasAsociadas = nReserva.MostrarReserva().Where(c => c.ReservaId == int.Parse(teatroId)).ToList();
            if (ReservasAsociadas.Count > 0)
            {
                MessageBox.Show("El reserva esta asociado a 'Reservas', desvinculelo para poder eliminar ");
            }
            else
            {
                nTeatros.EliminarTeatros(int.Parse(teatroId));
                CargarDatos();
                LimpiarDatos();
            }
        }

        private void dgTeatros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgTeatros.Rows.Count)
            {
                DataGridViewRow row = dgTeatros.Rows[e.RowIndex];
                txtTeatroId.Text = row.Cells["TeatroId"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtCapacidad.Text = row.Cells["Capacidad"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgTeatros.CurrentRow.Cells["Estado"].Value.ToString());
            }
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
