using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class Teatros
    {
        [Key]
        public int TeatroId { get; set; }
        [Required]
        [MaxLength(75)]
        public string Nombre { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
