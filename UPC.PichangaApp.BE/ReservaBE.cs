using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.PichangaApp.BE
{
    public class ReservaBE
    {
        public int id_reserva { get; set; }
        public int id_cancha { get; set; }
        public int id_usuario { get; set; }
        public int cantidad_jugadores { get; set; }
        public DateTime fecha { get; set; }
        public int hora { get; set; }
        public bool estado { get; set; }
    }
}
