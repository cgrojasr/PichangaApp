using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPC.PichangaApp.BE;
using UPC.PichangaApp.BL;

namespace UPC.PichangaApp.WF
{
    public partial class frmReservaRegistro : Form
    {
        public frmReservaRegistro()
        {
            InitializeComponent();
            CargaCancha();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var objReservaBE = new ReservaBE {
                id_usuario = GlobalVariables.id_usaurio,
                id_cancha = (int)cbCancha.SelectedValue,
                cantidad_jugadores = int.Parse(txtCantidadJugadores.Text),
                fecha = dtpFecha.Value,
                hora = (int)cbHora.SelectedValue,
                estado = true
            };
        }

        #region
        private void CargaCancha() {
            var objCanchaBL = new CanchaBL();
            var canchas = objCanchaBL.ListarActivas();
            cbCancha.Items.AddRange(canchas.ToArray());
            cbCancha.ValueMember = "id_cancha";
            cbCancha.DisplayMember = "nombre";
        }
        #endregion
    }
}
