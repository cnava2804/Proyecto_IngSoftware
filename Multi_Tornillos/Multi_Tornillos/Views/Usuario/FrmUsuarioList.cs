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
using Multi_Tornillos.Views.Usuario;

namespace Multi_Tornillos.Views.Usuario
{
    public partial class FrmUsuarioList : Form
    {
        UsuarioController controller;
        public FrmUsuarioList()
        {
            InitializeComponent();
            UpdateDates();
        }

        private void UpdateDates()
        {
            controller = new UsuarioController();
            var usu = controller.GetUsuarios(txtBuscar.Text);
            dgDatos.DataSource = usu;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuarioInsert insert = new FrmUsuarioInsert();
            insert.ShowDialog();
            insert.Dispose();
            UpdateDates();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var a = controller.GetUsuario(Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value));
            if (a != null)
            {
                FrmUsuarioEdit edit = new FrmUsuarioEdit(a);
                edit.ShowDialog();
                edit.Dispose();
                UpdateDates();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var a = controller.GetUsuario(Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value));
            if (a != null)
            {
                FrmUsuarioDelete delete = new FrmUsuarioDelete(a);
                delete.ShowDialog();
                delete.Dispose();
                UpdateDates();
            }
        }
    }
}
