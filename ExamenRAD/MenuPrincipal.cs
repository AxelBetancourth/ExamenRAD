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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PClientes clientes = new PClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PReserva reserva = new PReserva();
            reserva.MdiParent = this;
            reserva.Show();
        }

        private void tsEeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PTeatros teatros = new PTeatros();
            teatros.MdiParent = this;
            teatros.Show();
        }
    }
}
