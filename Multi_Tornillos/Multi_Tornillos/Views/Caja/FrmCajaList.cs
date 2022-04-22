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
    public partial class FrmCajaList : Form
    {
        CajaController Cajas;


        public FrmCajaList()
        {
            InitializeComponent();

            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            Cajas = new CajaController();
            var caj = Cajas.GetCajas(txtBuscar.Text);
            dgDatos.DataSource = caj;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCajaInsert insert = new FrmCajaInsert();
            insert.ShowDialog();
            insert.Dispose();
            ActualizarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = Cajas.GetCaja(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c!=null)
            {
                FrmCajaEdit edit = new FrmCajaEdit(c);
                edit.ShowDialog();
                edit.Dispose();
                ActualizarDatos();
            }

                        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var c = Cajas.GetCaja(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c!=null)
            {
                FrmCajaDelete delete = new FrmCajaDelete(c);
                delete.ShowDialog();
                delete.Dispose();
                ActualizarDatos();
            }

           
        }

       
    }
}
