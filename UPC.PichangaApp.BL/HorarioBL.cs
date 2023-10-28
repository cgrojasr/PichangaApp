using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.DA;

namespace UPC.PichangaApp.BL
{
    public class HorarioBL
    {
        private readonly HorarioDA objHorarioDA;

        public HorarioBL()
        {
            objHorarioDA = new HorarioDA();
        }

        public List<HorarioBE_ListarComboBox> Listar_Combobox(int id_cancha, DateTime fecha) {
            try
            {
                var horarios = objHorarioDA.Listar_Combobox(id_cancha, fecha);
                if (horarios.Count > 0)
                    return horarios;
                else
                    throw new Exception("No se encuentra con horarios disponibles");
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
