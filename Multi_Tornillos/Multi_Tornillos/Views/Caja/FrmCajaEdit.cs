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
    public partial class FrmCajaEdit : Form
    {
        private Multi_TornillosDAL.Caja caja;
        private readonly CajaController controller;
    


        public FrmCajaEdit(Multi_TornillosDAL.Caja caja)
        {
            InitializeComponent();

            this.controller = new CajaController();
            this.caja = caja;

            txtId.Text = caja.CajaId.ToString();
            txtCajaNombre.Text = caja.CajaNumero;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            Multi_TornillosDAL.Caja caja = new Multi_TornillosDAL.Caja
            {
                CajaId = this.caja.CajaId,
                CajaNumero= txtCajaNombre.Text
            };

            if (controller.Edit(caja))
            {
                MessageBox.Show("Editado Correctamente");
                controller.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("error al Editar");
            }
        }
    }
}
