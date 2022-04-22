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
    public partial class FrmDiasEdit : Form
    {

        private readonly DiaController controller;
        private Multi_TornillosDAL.Dia dia;
        

        public FrmDiasEdit(Multi_TornillosDAL.Dia dia)
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
            Multi_TornillosDAL.Dia dia = new Multi_TornillosDAL.Dia
            {
                DiaId = this.dia.DiaId,
                DiaNombre = txtDiaNombre.Text
            };

            if (controller.Edit(dia))
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
