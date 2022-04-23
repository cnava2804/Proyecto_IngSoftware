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

namespace Multi_Tornillos.Views
{
    public partial class FrmLogin : Form
    {
        private readonly FlujoDeCajaEntities db;
        UsuarioController controller;
        public FrmLogin()
        {
            InitializeComponent();
            controller = new UsuarioController();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            var resu = controller.log(txtRTN.Text, txtPassword.Text);
            if (resu == 1)
            {
                if (UsuarioLog.UsuarioTipo == "Administrador")
                {
                    FrmMenu menu = new FrmMenu();
                    this.Hide();
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
    }
}
