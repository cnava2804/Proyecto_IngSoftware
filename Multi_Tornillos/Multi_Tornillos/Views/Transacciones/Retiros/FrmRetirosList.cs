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

namespace Multi_Tornillos.Views.Transacciones.Retiros
{
    public partial class FrmRetirosList : Form
    {
        int decidido;
        RetirosController controller;
        public FrmRetirosList()
        {
            InitializeComponent();
            UpdateDates();
            lblCajaNumero.Text = UsuarioLog.CajaNumero;
        }

        private void UpdateDates()
        {
            controller = new RetirosController();
            var saldoInicial = controller.GetRetiros(txtBuscar.Text);
            dgDatos.DataSource = saldoInicial;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRetirosInsert retirosInsert = new FrmRetirosInsert();
            retirosInsert.ShowDialog();
            retirosInsert.Dispose();
            UpdateDates();
        }

        private void FrmDepositosList_FormClosed(object sender, FormClosedEventArgs e)
        {
            decidido = 0;
            UsuarioLog.decision = decidido;
        }
    }
}
