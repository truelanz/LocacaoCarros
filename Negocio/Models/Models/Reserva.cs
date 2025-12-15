using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdCarro { get; set; }
        public DateTime DataReserva { get; set; }
    }
}
