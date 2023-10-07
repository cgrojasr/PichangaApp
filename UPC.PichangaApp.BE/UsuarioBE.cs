using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.PichangaApp.BE
{
    public class UsuarioBE
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string nombre_usuario { get; set; }
        public string password { get; set; }
        public bool activo { get; set; }
    }
}
