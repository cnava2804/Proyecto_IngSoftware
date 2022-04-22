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
    public partial class FrmSemanaEdit : Form
    {

        private readonly SemanaController controller;
        private Multi_TornillosDAL.Semana semana;
        

        public FrmSemanaEdit(Multi_TornillosDAL.Semana semana)
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
            Multi_TornillosDAL.Semana semana = new Multi_TornillosDAL.Semana
            {
                SemanaId = this.semana.SemanaId,
                SemanaNombre = txtSemanaNombre.Text
            };

            if (controller.Edit(semana))
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
