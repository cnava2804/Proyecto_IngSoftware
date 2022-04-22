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

        private void mnuListaDias_Click(object sender, EventArgs e)
        {
            FrmDiasList dias = new FrmDiasList();
            tabControl1.TabPages.Add(dias);
        }

        private void listaSemanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSemanasList semanas = new FrmSemanasList();
            tabControl1.TabPages.Add(semanas);
        }
    }
}
