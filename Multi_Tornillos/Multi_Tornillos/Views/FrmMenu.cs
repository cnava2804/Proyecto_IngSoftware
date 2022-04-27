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
using Multi_TornillosDAL.ViewModels;
using System.Data.SqlClient;

namespace Multi_Tornillos.Views.Caja
{

    public partial class FrmMenu : Form
    {

        public readonly FlujoDeCajaEntities db;
        public FrmMenu()
        {
            InitializeComponent();
            //SaldoCaja();
            MaxId();


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
            Multi_TornillosDAL.ViewModels.CajaViewModel saldocaja = new Multi_TornillosDAL.ViewModels.CajaViewModel
            {
                
            };
            txtSaldoCaja.Text = Convert.ToDecimal(saldocaja.CajaSaldoTotal).ToString();

            //string connstring = "connection string";
            //using (SqlConnection cn = new SqlConnection(connstring))
            //{
            //    cn.Open();

            //    string sql = "SELECT campo1 FROM Caja WHERE id =@id";
            //    SqlCommand cmd = new SqlCommand(query, cn);
            //    cmd.Parameters.AddwithValue("@id", 4950);

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        txtSaldoCaja.Text = Convert.ToString(reader("CajaSaldoTotal"));
            //    }

            //}


        }

        private void MaxId()
        {
            string sql = @"SELECT TOP 1 CajaSaldoTotal FROM Caja WHERE CajaSaldoTotal = CajaSaldoTotal ORDER BY CajaSaldoTotal DESC";
            using (SqlConnection conn = new SqlConnection("data source=Andrik-PC;initial catalog=FlujoDeCaja;persist security info=True;user id=sa;password=1234;MultipleActiveResultSets=True"))
            {
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                string codmax = Convert.ToString(command.ExecuteScalar());
                int cod = Convert.ToInt32(codmax);
                txtSaldoCaja.Text = Convert.ToString(cod);
            }
        }


    }
}
