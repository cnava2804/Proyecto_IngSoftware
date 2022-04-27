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
    public partial class FrmCierreDiaList : Form
    {
        CierreDiaController controller;
        public FrmCierreDiaList()
        {
            InitializeComponent();
            UpdateDates();
            lblCajaNumero.Text = UsuarioLog.CajaNumero;
            lblIdCaja.Text = UsuarioLog.CajaId;
        }

        private void UpdateDates()
        {
            controller = new CierreDiaController();
            var cierreDia = controller.GetCierreDias(txtBuscar.Text);
            dgDatos.DataSource = cierreDia;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCierreDiaInsert cierreDiaInsert = new FrmCierreDiaInsert();
            cierreDiaInsert.ShowDialog();
            cierreDiaInsert.Dispose();
            UpdateDates();
        }
    }
}
