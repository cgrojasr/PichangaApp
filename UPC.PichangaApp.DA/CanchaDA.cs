using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;

namespace UPC.PichangaApp.DA
{
    public class CanchaDA
    {
        public List<CanchaBE> ListarActivas() { 
            var canchas = new List<CanchaBE>();
            var cancha1 = new CanchaBE { 
                id_cancha = 1,
                nombre = "Cancha 1",
                activo = true
            };

            var cancha2 = new CanchaBE
            {
                id_cancha = 2,
                nombre = "Cancha 2",
                activo = false            };

            var cancha3 = new CanchaBE
            {
                id_cancha = 3,
                nombre = "Cancha 3",
                activo = true
            };
            canchas.Add(cancha1);
            canchas.Add(cancha2);
            canchas.Add(cancha3);

            var query = canchas.FindAll(x=>x.activo).ToList();
            return query;
        }
    }
}
