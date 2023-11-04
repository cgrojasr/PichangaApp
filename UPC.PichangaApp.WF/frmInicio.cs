using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPC.PichangaApp.BL;

namespace UPC.PichangaApp.WF
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            CargarReservas(GlobalVariables.id_usaurio);
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            var frmReservaRegistro = new frmReservaRegistro(false);
            frmReservaRegistro.ShowDialog();
        }

        private void CargarReservas(int id_cliente) {
            var objReservaBL = new ReservaBL();
            var reservas = objReservaBL.ListarPorCliente(id_cliente);

            dgvReservas.DataSource = reservas;
        }

        private void dgvReservas_DoubleClick(object sender, EventArgs e)
        {
            var cell = dgvReservas.CurrentCell;
            if(cell.ColumnIndex == 1 )
            {
                var id_reserva = dgvReservas.CurrentCell.Value;
                var frmReserva = new frmReservaRegistro(true, (int)id_reserva);
                frmReserva.ShowDialog();
            }
        }
    }
}
