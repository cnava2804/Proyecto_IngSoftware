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
    public partial class FrmSemanasList : Form
    {
        SemanaController Semana;


        public FrmSemanasList()
        {
            InitializeComponent();

            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            Semana = new SemanaController();
            var sem = Semana.GetSemanas(txtBuscar.Text);
            dgDatos.DataSource = sem;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmSemanaInsert insert = new FrmSemanaInsert();
            insert.ShowDialog();
            insert.Dispose();
            ActualizarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = Semana.GetSemana(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c != null)
            {
                FrmSemanaEdit edit = new FrmSemanaEdit(c);
                edit.ShowDialog();
                edit.Dispose();
                ActualizarDatos();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var c = Semana.GetSemana(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c != null)
            {
                FrmSemanaDelete delete = new FrmSemanaDelete(c);
                delete.ShowDialog();
                delete.Dispose();
                ActualizarDatos();
            }


        }


    }
}
