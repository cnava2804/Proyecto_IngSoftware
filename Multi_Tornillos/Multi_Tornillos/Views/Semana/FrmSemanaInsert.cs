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
    public partial class FrmSemanaInsert : Form
    {

        private readonly SemanaController controller;


        public FrmSemanaInsert()
        {
            InitializeComponent();
            controller = new SemanaController();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Multi_TornillosDAL.Semana semana = new Multi_TornillosDAL.Semana
            {
                SemanaNombre = txtSemanaNombre.Text
            };

            if (controller.Add(semana))
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
