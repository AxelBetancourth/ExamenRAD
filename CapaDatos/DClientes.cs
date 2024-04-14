using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DClientes
    {
        UnitOfWork _unitOfWork;

        public DClientes()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        public List<Clientes> TodosLosClientes()
        {
            return _unitOfWork.Repository<Clientes>().Consulta().ToList();
        }
        public int GuardarClientes(Clientes clientes)
        {
            if (clientes.ClienteId == 0)
            {
                _unitOfWork.Repository<Clientes>().Agregar(clientes);
                return _unitOfWork.Guardar();
            }
            else
            {
                var ClientesInDb = _unitOfWork.Repository<Clientes>().Consulta().FirstOrDefault(c => c.ClienteId == clientes.ClienteId);
                if (ClientesInDb != null)
                {
                    ClientesInDb.Nombres = clientes.Nombres;
                    ClientesInDb.Apellidos = clientes.Apellidos;
                    ClientesInDb.FechaIngreso = clientes.FechaIngreso;
                    ClientesInDb.Estado = clientes.Estado;
                    _unitOfWork.Repository<Clientes>().Editar(ClientesInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int EliminarClientes(int clienteId)
        {
            var ClientesInDb = _unitOfWork.Repository<Clientes>().Consulta().FirstOrDefault(c => c.ClienteId == clienteId);
            if (ClientesInDb != null)
            {
                _unitOfWork.Repository<Clientes>().Eliminar(ClientesInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

    }
}
