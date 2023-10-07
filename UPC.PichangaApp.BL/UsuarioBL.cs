using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.DA;

namespace UPC.PichangaApp.BL
{
    public class UsuarioBL
    {
        private readonly UsuarioDA objUsuarioDA;
        public UsuarioBL()
        {
            objUsuarioDA = new UsuarioDA();
        }

        public int Login(UsuarioBE_Login usuario_login)
        {
			try
			{
				var id_usuario = objUsuarioDA.Login(usuario_login);
                if (id_usuario >= 1)
                    return id_usuario;
                else {
                    var e = new Exception("El usuario es incorrecto");
                    throw e;
                }
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
