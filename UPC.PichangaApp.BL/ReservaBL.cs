using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.DA;

namespace UPC.PichangaApp.BL
{
    public class ReservaBL
    {
        private readonly ReservaDA objReservaDA;

        public ReservaBL()
        {
            objReservaDA = new ReservaDA();
        }

        public int Registrar(ReservaBE objReservaBE) {
            return objReservaDA.Registrar(objReservaBE);
        }

        public List<ReservaBE_ListarPorCliente> ListarPorCliente(int id_cliente) {
            return objReservaDA.ListarPorCliente(id_cliente);
        }

        public ReservaBE BuscarPorId(int id_reserva) { 
            return objReservaDA.BuscarPorId(id_reserva);
        }

        public bool Modificar(ReservaBE objReservaBE)
        {
            return objReservaDA.Modificar(objReservaBE);
        }
    }
}
