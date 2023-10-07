using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.DA;

namespace UPC.PichangaApp.BL
{
    public class CanchaBL
    {
        private readonly CanchaDA objCanchaDA;
        public CanchaBL() { 
            objCanchaDA = new CanchaDA();
        }

        public List<CanchaBE> ListarActivas() {
            try
            {
                return objCanchaDA.ListarActivas();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
