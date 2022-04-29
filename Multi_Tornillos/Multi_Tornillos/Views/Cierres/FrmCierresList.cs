using Multi_Tornillos.Views.Cierres;
using Multi_TornillosBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tornillos.Views.CierreDia
{
    public partial class FrmCierresList : Form
    {
        CierresController controller;
        public FrmCierresList()
        {
            InitializeComponent();
            UpdateDates();
            lblCajaNumero.Text = UsuarioLog.CajaNumero;
            lblIdCaja.Text = UsuarioLog.CajaId;
        }

        private void UpdateDates()
        {
            controller = new CierresController();
            var cierre = controller.GetCierres(txtBuscar.Text);
            dgDatos.DataSource = cierre;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCierresInsert cierreInsert = new FrmCierresInsert();
            cierreInsert.ShowDialog();
            cierreInsert.Dispose();
            UpdateDates();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            UpdateDates();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = controller.GetCierre(
               Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c != null)
            {
                FrmCierresEdit edit = new FrmCierresEdit(c);
                edit.ShowDialog();
                edit.Dispose();
                UpdateDates();
            }
        }
    }
}
