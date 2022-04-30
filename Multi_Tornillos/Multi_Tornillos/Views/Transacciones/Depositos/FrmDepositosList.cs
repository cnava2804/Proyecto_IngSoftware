using Multi_Tornillos.Views.Transacciones.Depositos;
using Multi_TornillosBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tornillos.Views.Transacciones.Depositos
{
    public partial class FrmDepositosList : Form
    {
        int decidido;
        DepositosController controller;
        public FrmDepositosList()
        {
            InitializeComponent();
            UpdateDates();
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

        private void FrmDepositosList_FormClosed(object sender, FormClosedEventArgs e)
        {
            decidido = 0;
            UsuarioLog.decision = decidido;
            SaldoActu();
        }
     
        public void SaldoActu()
        {
            FrmMenu menu = new FrmMenu();
            string sql = @"SELECT TOP 1 CajaSaldoTotal FROM Caja WHERE CajaId ='" + (UsuarioLog.CajaId) + "' ORDER BY CajaId ASC";
            SqlConnection conn = new SqlConnection("data source=Andrik-PC;initial catalog=FlujoDeCaja;persist security info=True;user id=sa;password=1234;MultipleActiveResultSets=True");
            {
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                string codmax = Convert.ToString(command.ExecuteScalar());
                int cod = Convert.ToInt32(codmax) + 1;
                menu.txtSaldoCaja.Text = Convert.ToString(cod);
            }
        }

        private void FrmDepositosList_Load(object sender, EventArgs e)
        {
            SaldoActu();
        }
    }
}
