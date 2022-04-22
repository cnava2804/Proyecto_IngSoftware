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
    public partial class FrmSemanaDelete : Form
    {
        private Multi_TornillosDAL.Semana semana;
        private readonly SemanaController controller;


        public FrmSemanaDelete(Multi_TornillosDAL.Semana semana)
        {
            InitializeComponent();

            this.controller = new SemanaController();
            this.semana = semana;

            txtId.Text = semana.SemanaId.ToString();
            txtSemanaNombre.Text = semana.SemanaNombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "¿Desea Eliminar esta Semana?",
                "Confirme acción",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (controller.Delete(semana.SemanaId))
                {
                    MessageBox.Show("Semana Eliminada exitosamente");
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
