using Multi_TornillosBLL;
using Multi_TornillosDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tornillos.Views.Cierres
{
    public partial class FrmCierresInsert : Form
    {
        public SqlConnection cn = new SqlConnection("data source=DESKTOP-I3P9B28;initial catalog=FlujoDeCaja;persist security info=True;user id=sa;password=1234;MultipleActiveResultSets=True");

        private readonly CierresController controller;
        public FrmCierresInsert()
        {
            string usuario;
            int usuarioid;

            InitializeComponent();
            controller = new CierresController();           
            usuario = UsuarioLog.UsuarioNombre;
            lblusuario.Text = usuario;
            lblIdCaja.Text = UsuarioLog.CajaId;
            lblCajaNumero.Text = UsuarioLog.CajaNumero;
            usuarioid = UsuarioLog.UsuarioId;
            lblusuarioid.Text = Convert.ToString(usuarioid);
            btnGuardar.Enabled = false;

            
        }

       
        private void GetCierresFechas()
        {
            SqlDataAdapter da = new SqlDataAdapter("buscarfechas", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@fechaInicial", SqlDbType.DateTime).Value=dtFechaInicial.Text;
            da.SelectCommand.Parameters.Add("@fechaFinal", SqlDbType.DateTime).Value = dtFechaFinal.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgDatosFechas.DataSource = dt;
        }

        private void TotalCierres()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgDatosFechas.Rows)
            {
                total += Convert.ToDouble(row.Cells[1].Value);
            }

            txtResultado.Text = Convert.ToString(total);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetCierresFechas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            TotalCierres();
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Multi_TornillosDAL.Cierres cierres = new Multi_TornillosDAL.Cierres
            {
                CierreFechaInicial = Convert.ToDateTime(dtFechaInicial.Text),
                CierreFechaFinal= Convert.ToDateTime(dtFechaFinal.Text),
                TipoCierre= txtTipoCierre.Text,
                CierreTotal = Convert.ToDecimal(txtResultado.Text),
                CierreFecha = DateTime.Now,                
                UsuarioId = Convert.ToInt32(lblusuarioid.Text),
                CajaId = Convert.ToInt32(lblIdCaja.Text)

            };
            if (controller.Add(cierres))
            {
                MessageBox.Show("ingresado correctamente");
                controller.Dispose();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Error para agregar");
            }
        }
    }
}
