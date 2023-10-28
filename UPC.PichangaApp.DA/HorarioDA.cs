using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.EF;

namespace UPC.PichangaApp.DA
{
    public class HorarioDA
    {
        private readonly dbPichangerosEntities db;
        public HorarioDA() { 
            db = new dbPichangerosEntities();
        }

        public List<HorarioBE_ListarComboBox> Listar_Combobox(int id_cancha, DateTime fecha) {
            var query = from hor in db.horarios
                        where hor.id_cancha.Equals(id_cancha) && hor.fecha.Equals(fecha)
                        select hor;

            return query.ToList().Select(x=> new HorarioBE_ListarComboBox { 
                id_horario = x.id_horario,
                hora = x.hora.ToString("HH:mm")
            }).ToList();
        }
    }
}
