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
    public class DTeatros
    {
        UnitOfWork _unitOfWork;
        public DTeatros()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int TeatroId { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Estado { get; set; }

        public List<Teatros> TodosLosTeatros()
        {
            return _unitOfWork.Repository<Teatros>().Consulta().ToList();
        }
        public int GuardarTeatros(Teatros teatros)
        {
            if (teatros.TeatroId == 0)
            {
                _unitOfWork.Repository<Teatros>().Agregar(teatros);
                return _unitOfWork.Guardar();
            }
            else
            {
                var TeatrosInDb = _unitOfWork.Repository<Teatros>().Consulta().FirstOrDefault(c => c.TeatroId == teatros.TeatroId);
                if (TeatrosInDb != null)
                {
                    TeatrosInDb.Nombre = teatros.Nombre;
                    TeatrosInDb.Capacidad = teatros.Capacidad;
                    TeatrosInDb.Estado = teatros.Estado;
                    _unitOfWork.Repository<Teatros>().Editar(TeatrosInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int EliminarTeatros(int teatroId)
        {
            var TeatrosInDb = _unitOfWork.Repository<Teatros>().Consulta().FirstOrDefault(c => c.TeatroId == teatroId);
            if (TeatrosInDb != null)
            {
                _unitOfWork.Repository<Teatros>().Eliminar(TeatrosInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

    }
}
