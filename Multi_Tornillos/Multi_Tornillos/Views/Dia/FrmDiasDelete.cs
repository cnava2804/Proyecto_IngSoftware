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
    public partial class FrmDiasDelete : Form
    {
        private Multi_TornillosDAL.Dia dia;
        private readonly DiaController controller;


        public FrmDiasDelete(Multi_TornillosDAL.Dia dia)
        {
            InitializeComponent();

            this.controller = new DiaController();
            this.dia = dia;

            txtId.Text = dia.DiaId.ToString();
            txtDiaNombre.Text = dia.DiaNombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "¿Desea Eliminar este Dia?",
                "Confirme acción",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (controller.Delete(dia.DiaId))
                {
                    MessageBox.Show("Dia Eliminado exitosamente");
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
