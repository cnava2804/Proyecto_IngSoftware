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
    public partial class FrmDiasInsert : Form
    {

        private readonly DiaController controller;


        public FrmDiasInsert()
        {
            InitializeComponent();
            controller = new DiaController();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Multi_TornillosDAL.Dia dia = new Multi_TornillosDAL.Dia
            {
                DiaNombre = txtDiaNombre.Text
            };

            if (controller.Add(dia))
            {
                MessageBox.Show("ingresado correctamente");
                controller.Dispose();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Error para agregar");
            }
        }
    }
}
