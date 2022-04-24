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

namespace Multi_Tornillos.Views.Bitacora
{
    public partial class FrmBitacora : Form
    {
        BitacoraController bitacoracontroller;
        public FrmBitacora()
        {
            InitializeComponent();
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            bitacoracontroller = new BitacoraController();
            var bita = bitacoracontroller.GetBitacoras(txtBuscar.Text);
            dgDatos.DataSource = bita;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
    }
}
