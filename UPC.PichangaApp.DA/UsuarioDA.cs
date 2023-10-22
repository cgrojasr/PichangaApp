using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.EF;

namespace UPC.PichangaApp.DA
{
    public class UsuarioDA
    {
        private readonly dbPichangerosEntities db;

        public UsuarioDA()
        {
            db = new dbPichangerosEntities();
        }
        public int Login(UsuarioBE_Login usuario_login)
        {
            //Conectar a la base de datos y consultar los datos del usuario
            var query = (from cli in db.clientes
                        where cli.activo && cli.usuario.Equals(usuario_login.usuario) && cli.password.Equals(usuario_login.password)
                        select cli.id_cliente).Single();

            return query;
        }
    }
}
