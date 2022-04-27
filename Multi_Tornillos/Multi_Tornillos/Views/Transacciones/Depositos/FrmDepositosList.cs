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

namespace Multi_Tornillos.Views.Transacciones.Depositos
{
    public partial class FrmDepositosList : Form
    {
        DepositosController controller;
        public FrmDepositosList()
        {
            InitializeComponent();
            UpdateDates();
            lblCajaNumero.Text = UsuarioLog.CajaNumero;
        }

        private void UpdateDates()
        {
            controller = new DepositosController();
            var saldoInicial = controller.GetDepositos(txtBuscar.Text);
            dgDatos.DataSource = saldoInicial;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDepositosInsert depositosInsert = new FrmDepositosInsert();
            depositosInsert.ShowDialog();
            depositosInsert.Dispose();
            UpdateDates();
        }
    }
}
