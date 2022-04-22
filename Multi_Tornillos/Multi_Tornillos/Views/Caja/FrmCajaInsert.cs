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

namespace Multi_Tornillos.Views.Caja
{
    public partial class FrmCajaInsert : Form
    {

        private readonly CajaController controller;


        public FrmCajaInsert()
        {
            InitializeComponent();
            controller = new CajaController();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Multi_TornillosDAL.Caja caja = new Multi_TornillosDAL.Caja
            {
                CajaNumero = txtCajaNombre.Text
            };

            if (controller.Add(caja))
            {
                MessageBox.Show("ingresado correctamente");
                controller.Dispose();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Erro para agregar");
            }
        }
    }
}
