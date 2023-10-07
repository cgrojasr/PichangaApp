using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPC.PichangaApp.BE;

namespace UPC.PichangaApp.WF
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var usuario_login = new UsuarioBE_Login {
                nombre_usuario = txtUsuario.Text,
                password = txtPassword.Text
            };
        }
    }
}
