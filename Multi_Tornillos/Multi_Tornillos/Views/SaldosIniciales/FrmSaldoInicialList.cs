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

namespace Multi_Tornillos.Views.SaldosIniciales
{
    public partial class FrmSaldoInicialList : Form
    {
        SaldosInicialesController controller;
        public FrmSaldoInicialList()
        {
            InitializeComponent();
            UpdateDates();
        }

        public string idcaja;
        private void UpdateDates()
        {
            controller = new SaldosInicialesController();
            var saldoInicial = controller.GetSaldosIniciales(txtBuscar.Text);
            dgDatos.DataSource = saldoInicial;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmSaldoInicialInsert saldoInicialInsert = new FrmSaldoInicialInsert();
            saldoInicialInsert.ShowDialog();
            saldoInicialInsert.Dispose();
            UpdateDates();
        }

        private void FrmSaldoInicialList_Load(object sender, EventArgs e)
        {
            lblIdCaja.Text = UsuarioLog.CajaId;
            lblCajaNumero.Text=UsuarioLog.CajaNumero;
        }
    }
}
