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
    public partial class FrmCajaDelete : Form
    {
        private Multi_TornillosDAL.Caja caja;
        private readonly CajaController controller;
        public FrmCajaDelete(Multi_TornillosDAL.Caja caja)
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
            var confirmResult = MessageBox.Show(
                "¿Desea Eliminar esta Caja?",
                "Confirme acción",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (controller.Delete(caja.CajaId))
                {
                    MessageBox.Show("Caja Eliminada exitosamente");
                    controller.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar");
                }
            }
           

        }
    }
}
