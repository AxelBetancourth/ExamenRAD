using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        [Required]
        public int TeatroId { get; set; }
        public Teatros Teatros { get; set; }
        [Required]
        public int ClienteId { get; set; }
        public Clientes Clientes { get; set; }
        [Required]
        public DateTime FechaReserva { get; set; }
    }
}
