using Multi_Tornillos.Views.SaldosIniciales;
using Multi_Tornillos.Views.CierreDia;
using Multi_Tornillos.Views.Transacciones.Depositos;
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
using Multi_TornillosDAL;

namespace Multi_Tornillos.Views.Caja
{

    public partial class FrmMenu : Form
    {

        public readonly FlujoDeCajaEntities db;
        public readonly CajaController cajaController;
        public FrmMenu()
        {
            InitializeComponent();
            SaldoCaja();
        }

        private void mnuListaCajas_Click(object sender, EventArgs e)
        {
            FrmCajaList cajas = new FrmCajaList();
            tabControl1.TabPages.Add(cajas);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Multi_Tornillos.Views.Usuario.FrmUsuarioList user = new Usuario.FrmUsuarioList();
            tabControl1.TabPages.Add(user);
        }

        private void saldoInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmSaldoInicialList saldoInicial = new FrmSaldoInicialList();
            tabControl1.TabPages.Add(saldoInicial);

        }
        private void depositosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepositosList depositos = new FrmDepositosList();
            tabControl1.TabPages.Add(depositos);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblCajaNumero.Text = UsuarioLog.CajaNumero;
            lblCajaId.Text = UsuarioLog.CajaId;
        }

        private void cierreDeDiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCierreDiaList cierre = new FrmCierreDiaList();
            tabControl1.TabPages.Add(cierre);
        }

        private void SaldoCaja()
        {
            Multi_TornillosDAL.Caja saldocaja = new Multi_TornillosDAL.Caja
            {
                CajaSaldoTotal = Convert.ToDecimal(lblSaldoCaja.Text)
            };
        }
    }
}
