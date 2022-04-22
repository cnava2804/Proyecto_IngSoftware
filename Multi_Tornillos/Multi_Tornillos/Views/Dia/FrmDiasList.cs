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
    public partial class FrmDiasList : Form
    {
        DiaController Dias;


        public FrmDiasList()
        {
            InitializeComponent();

            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            Dias = new DiaController();
            var di = Dias.GetDias(txtBuscar.Text);
            dgDatos.DataSource = di;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDiasInsert insert = new FrmDiasInsert();
            insert.ShowDialog();
            insert.Dispose();
            ActualizarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = Dias.GetDia(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c != null)
            {
                FrmDiasEdit edit = new FrmDiasEdit(c);
                edit.ShowDialog();
                edit.Dispose();
                ActualizarDatos();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var c = Dias.GetDia(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c != null)
            {
                FrmDiasDelete delete = new FrmDiasDelete(c);
                delete.ShowDialog();
                delete.Dispose();
                ActualizarDatos();
            }


        }


    }
}
