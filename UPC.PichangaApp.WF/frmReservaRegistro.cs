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
            dtpFecha.Value = DateTime.Now;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var objReserva = new ReservaBE {
                id_cliente = GlobalVariables.id_usaurio,
                cantidad_disponible = int.Parse(txtCantidadJugadores.Text),
                id_horario = (int)cbCancha.SelectedValue,
                activo = true
            };

            var objReservaBL = new ReservaBL();
            objReservaBL.Registrar(objReserva);

            Close();
        }

        private void cbCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id_cancha = ((CanchaBE)cbCancha.SelectedItem).id_cancha;
            CargaHorario(id_cancha, dtpFecha.Value.Date);
            CargaCapacidad(id_cancha);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            var id_cancha = ((CanchaBE)cbCancha.SelectedItem).id_cancha;
            CargaHorario(id_cancha, dtpFecha.Value.Date);
            CargaCapacidad(id_cancha);
        }

        #region
        private void CargaCancha() {
            var objCanchaBL = new CanchaBL();
            var canchas = objCanchaBL.ListarActivas();
            cbCancha.DataSource = canchas;
            cbCancha.ValueMember = "id_cancha";
            cbCancha.DisplayMember = "nombre";
        }

        private void CargaHorario(int id_cancha, DateTime fecha)
        {
            var objHorarioBL = new HorarioBL();
            var horarios = objHorarioBL.Listar_Combobox(id_cancha, fecha);
            cbHora.DataSource = horarios;
            cbHora.ValueMember = "id_horario";
            cbHora.DisplayMember = "hora";
        }

        private void CargaCapacidad(int id_cancha) {
            var objCanchaBL = new CanchaBL();
            txtCantidadJugadores.Text = objCanchaBL.Buscar_Capacidad(id_cancha).ToString();
        }

        #endregion
    }
}
