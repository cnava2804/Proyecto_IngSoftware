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
        obtenerdatoscmb cb = new obtenerdatoscmb();
        UsuarioController controller;
        public FrmLogin()
        {
            InitializeComponent();
            controller = new UsuarioController();
            cb.rellenar(cmbCajas);
            btnLoguear.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {

            

            if (txtRTN.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Hay campos vacios, por favor completelos todos.");
            }
            else
            {

                string password = Encrypt.GetSHA256(txtPassword.Text.Trim());
                string Loginusuario = txtRTN.Text;
                using (FlujoDeCajaEntities db = new FlujoDeCajaEntities())
                {
                    var pass = from u in db.Usuario
                               where u.UsuarioDNI == txtRTN.Text
                               && u.UsuarioPassword == password
                               select u;

                   
                    //if (resu == 1)
                    //{
                    var user = pass.FirstOrDefault();
                    if (user != null)
                    {
                        var resu = controller.log(txtRTN.Text, txtPassword.Text);

                        if (resu == 1)
                        {

                            if (UsuarioLog.UsuarioTipo == "Administrador")
                            {
                                FrmMenu menu = new FrmMenu();
                                this.Hide();
                                UsuarioLog.CajaId = lblidcaja.Text;
                                UsuarioLog.CajaNumero = cmbCajas.Text;
                                UsuarioLog.CajaSaldoTotal = lblSaldoC.Text;
                                menu.ShowDialog();
                                this.Show();
                                txtRTN.Text = "";
                                txtPassword.Text = "";
                            }
                            else
                            {
                                FrmMenu menu = new FrmMenu();
                                this.Hide();
                                UsuarioLog.CajaId = lblidcaja.Text;
                                UsuarioLog.CajaNumero = cmbCajas.Text;
                                UsuarioLog.CajaSaldoTotal = lblSaldoC.Text;
                                menu.ShowDialog();
                                this.Show();
                                txtRTN.Text = "";
                                txtPassword.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales Incorrectas");
                    }
                


                }


        
            }
     }

        private void cmbCajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCajas.SelectedIndex > 0)
            {
                string[] valore = cb.obtenerdatos(cmbCajas.Text);
                lblidcaja.Text = valore[0];
                lblSaldoC.Text = valore[2];
            };
            btnLoguear.Enabled = true;
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

