using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DReserva
    {
        UnitOfWork _unitOfWork;

        public DReserva()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int ReservaId { get; set; }
        public int TeatroId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaReserva { get; set; }

        public List<Reserva> TodasLasReservas()
        {
            return _unitOfWork.Repository<Reserva>().Consulta().Include(c => c.Clientes)
                .Include(c => c.Teatros)
                .ToList();
        }
        public int GuardarReserva(Reserva reserva)
        {
            if (reserva.ReservaId == 0)
            {
                _unitOfWork.Repository<Reserva>().Agregar(reserva);
                return _unitOfWork.Guardar();
            }
            else
            {
                var ReservaInDb = _unitOfWork.Repository<Reserva>().Consulta().FirstOrDefault(c => c.ReservaId == reserva.ReservaId);
                if (ReservaInDb != null)
                {
                    ReservaInDb.TeatroId = reserva.TeatroId;
                    ReservaInDb.ClienteId = reserva.ClienteId;
                    ReservaInDb.FechaReserva = reserva.FechaReserva;
                    _unitOfWork.Repository<Reserva>().Editar(ReservaInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int EliminarReserva(int reservaId)
        {
            var ReservaInDb = _unitOfWork.Repository<Reserva>().Consulta().FirstOrDefault(c => c.ReservaId == reservaId);
            if (ReservaInDb != null)
            {
                _unitOfWork.Repository<Reserva>().Eliminar(ReservaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
