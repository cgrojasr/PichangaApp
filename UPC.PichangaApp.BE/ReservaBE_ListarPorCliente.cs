using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.PichangaApp.BE
{
    public class ReservaBE_ListarPorCliente
    {
        public int id_reserva { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad_disponible { get; set; }
    }
}
