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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mnuListaCajas_Click(object sender, EventArgs e)
        {
            FrmCajaList cajas = new FrmCajaList();
            tabControl1.TabPages.Add(cajas);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Multi_Tornillos.Views.Usuario.FrmUsuarioList user = new Usuario.FrmUsuarioList();
            tabControl1.TabPages.Add(user);
        }
    }
}
