using CapaDatos.BaseDatos.Modelos;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NTeatros
    {
        private DTeatros dTeatros;

        public NTeatros()
        {
            dTeatros = new DTeatros();
        }
        public List<Teatros> MostrarTeatros()
        {
            return dTeatros.TodosLosTeatros();
        }
        public List<Teatros> TeatrosActivos()
        {
            return dTeatros.TodosLosTeatros().Where(c => c.Estado == true).ToList();
        }
        public int AgregarTeatros(Teatros teatros)
        {
            return dTeatros.GuardarTeatros(teatros);
        }
        public int EditarTeatros(Teatros teatros)
        {
            return dTeatros.GuardarTeatros(teatros);
        }
        public int EliminarTeatros(int teatroId)
        {
            return dTeatros.EliminarTeatros(teatroId);
        }
    }
}
