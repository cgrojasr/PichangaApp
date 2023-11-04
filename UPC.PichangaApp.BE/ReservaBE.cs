using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.PichangaApp.BE
{
    public class ReservaBE
    {
        public int id_reserva { get; set; } = 0;
        public int id_cliente { get; set; }
        public int id_horario { get; set; }
        public int id_cancha { get; set; } = 0;
        public DateTime fecha_reserva { get; set; } = DateTime.Now;
        public int cantidad_disponible { get; set; }
        public bool activo { get; set; }
    }
}
