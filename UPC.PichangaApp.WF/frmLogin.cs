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
using UPC.PichangaApp.BL;

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
            try
            {
                var usuario_login = new UsuarioBE_Login
                {
                    usuario = txtUsuario.Text,
                    password = txtPassword.Text
                };

                var objUsuarioBL = new UsuarioBL();
                GlobalVariables.id_usaurio = objUsuarioBL.Login(usuario_login);
                var frmInicio = new frmInicio();
                frmInicio.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación");
            }
            
        }
    }
}
