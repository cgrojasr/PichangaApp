using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.EF;

namespace UPC.PichangaApp.DA
{
    public class ReservaDA
    {
        private readonly dbPichangerosEntities db;

        public ReservaDA()
        {
            db = new dbPichangerosEntities();
        }

        public int Registrar(ReservaBE objReservaBE) {
            var objReserva = new reserva { 
                id_cliente = objReservaBE.id_cliente,
                id_horario = objReservaBE.id_horario,
                fecha_registro = DateTime.Now,
                cantidad_disponible = objReservaBE.cantidad_disponible,
                activo = true
            };

            db.reservas.Add(objReserva);
            db.SaveChanges();

            return objReserva.id_reserva;
        }

        public bool Modificar(ReservaBE objReservaBE) {
            var objReserva_Actualizar = db.reservas.ToList().Find(x => x.id_reserva.Equals(objReservaBE.id_reserva));
            objReserva_Actualizar.id_horario = objReservaBE.id_horario;
            objReserva_Actualizar.cantidad_disponible = objReservaBE.cantidad_disponible;
            objReserva_Actualizar.fecha_registro = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool Eliminar(int id_reserva) {
            db.reservas.Remove(db.reservas.ToList().Find(x => x.id_cliente.Equals(id_reserva)));
            db.SaveChanges();

            return true;
        }

        public ReservaBE BuscarPorId(int id_reserva) {
            var objReserva = db.reservas.ToList().Find(x => x.id_reserva.Equals(id_reserva));

            var objReservaBE = new ReservaBE { 
                id_reserva = objReserva.id_reserva,
                id_cliente = objReserva.id_cliente,
                id_horario = objReserva.id_horario,
                id_cancha = objReserva.horario.id_cancha,
                cantidad_disponible = objReserva.cantidad_disponible,
                activo = objReserva.activo
            };

            return objReservaBE;
        }

        public List<ReservaBE_ListarPorCliente> ListarPorCliente(int id_cliente) {
            var query = from res in db.reservas
                        where res.id_cliente.Equals(id_cliente) && res.activo
                        select new ReservaBE_ListarPorCliente
                        {
                            id_reserva = res.id_reserva,
                            fecha = res.horario.fecha,
                            cantidad_disponible = res.cantidad_disponible
                        };

            return query.ToList();
        }
    }
}
