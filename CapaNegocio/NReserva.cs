using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NReserva
    {
        private DReserva dReserva;

        public NReserva()
        {
            dReserva = new DReserva();
        }

        public List<Reserva> MostrarReserva()
        {
            return dReserva.TodasLasReservas();
        }
        public int AgregarReserva(Reserva reserva)
        {
            return dReserva.GuardarReserva(reserva);
        }
        public int EditarReserva(Reserva reserva)
        {
            return dReserva.GuardarReserva(reserva);
        }
        public int EliminarReserva(int reservaId)
        {
            return dReserva.EliminarReserva(reservaId);
        }

        public List<object> MostrarReservaGrid()
        {
            var reservas = dReserva.TodasLasReservas().Select(c => new
            {
                c.ReservaId,
                c.ClienteId,
                NombreClientes = c.Clientes.Nombres,
                c.TeatroId,
                NombreTeatro = c.Teatros.Nombre,
                c.FechaReserva,
            });
            return reservas.Cast<object>().ToList();
        }
    }
}
