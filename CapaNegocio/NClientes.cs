using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NClientes
    {
        private DClientes dClientes;

        public NClientes()
        {
            dClientes = new DClientes();
        }
        public List<Clientes> MostrarClientes()
        {
            return dClientes.TodosLosClientes();
        }
        public List<Clientes> ClientesActivos()
        {
            return dClientes.TodosLosClientes().Where(c => c.Estado == true).ToList();
        }
        public int AgregarClientes(Clientes clientes)
        {
            return dClientes.GuardarClientes(clientes);
        }
        public int EditarClientes(Clientes clientes)
        {
            return dClientes.GuardarClientes(clientes);
        }
        public int EliminarClientes(int clienteId)
        {
            return dClientes.EliminarClientes(clienteId);
        }
    }
}
