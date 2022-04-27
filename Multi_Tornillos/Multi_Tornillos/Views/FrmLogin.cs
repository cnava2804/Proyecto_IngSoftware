using Multi_TornillosBLL;
using Multi_TornillosDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multi_Tornillos.Views;
using Multi_Tornillos.Views.Caja;
using Multi_Tornillos.Views.SaldosIniciales;

namespace Multi_Tornillos.Views
{
    public partial class FrmLogin : Form
    {
        private readonly FlujoDeCajaEntities db;
        UsuarioController controller;
        private Multi_TornillosDAL.Caja ca;

        public FrmLogin()
        {
            InitializeComponent();
            controller = new UsuarioController();
            caja();

        }

        CajaController caj = new CajaController();
        private void caja()
        {

            cmbCajas.DataSource = caj.GetCajas(cmbCajas.Text);
            cmbCajas.DisplayMember = "CajaNumero";
            cmbCajas.ValueMember = "Cajaid";


        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            //FrmSaldoInicialInsert saldoInicialInsert = new FrmSaldoInicialInsert();
            //saldoInicialInsert.idcaja = cmbCajas.Text;
            //saldoInicialInsert.Show();

            var resu = controller.log(txtRTN.Text, txtPassword.Text);
            if (resu == 1)
            {
                if (UsuarioLog.UsuarioTipo == "Administrador")
                {
                    FrmMenu menu = new FrmMenu();
                    this.Hide();
                    menu.idcaja = lblid.Text;
                    menu.cajaNum = cmbCajas.Text;
                    menu.ShowDialog();
                    this.Show();

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }
        }

        private void cmbCajas_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblid.Text = Convert.ToString(cmbCajas.SelectedValue);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
