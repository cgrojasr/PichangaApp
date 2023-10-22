using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.EF;

namespace UPC.PichangaApp.DA
{
    public class CanchaDA
    {
        private readonly dbPichangerosEntities context;

        public CanchaDA()
        {
            context = new dbPichangerosEntities();
        }

        public List<CanchaBE> ListarActivas() {
            //var canchas = new List<CanchaBE>();
            //var cancha1 = new CanchaBE { 
            //    id_cancha = 1,
            //    nombre = "Cancha 1",
            //    activo = true
            //};

            //var cancha2 = new CanchaBE
            //{
            //    id_cancha = 2,
            //    nombre = "Cancha 2",
            //    activo = false            };

            //var cancha3 = new CanchaBE
            //{
            //    id_cancha = 3,
            //    nombre = "Cancha 3",
            //    activo = true
            //};
            //canchas.Add(cancha1);
            //canchas.Add(cancha2);
            //canchas.Add(cancha3);

            //var query = context.canchas.ToList().FindAll(x => x.activo);

            var query = (from can in context.canchas
                        where can.activo.Equals(true)
                        select new CanchaBE { 
                            id_cancha = can.id_cancha,
                            nombre = can.nombre
                        }).ToList();

            //var query = canchas.FindAll(x=>x.activo).ToList();
            return query;
        }
    }
}
