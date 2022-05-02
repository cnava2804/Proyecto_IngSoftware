using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multi_TornillosBLL;
using Multi_Tornillos.Views.SaldosIniciales;
using Multi_TornillosDAL;
using System.Data.SqlClient;

namespace Multi_Tornillos.Views.CierreDia
{
    public partial class FrmCierreDiaInsert : Form
    {
        private readonly CierreDiaController controller;

        int unlps, doslps, cincolps, diezlps, veintelps, cincuentalps, cienlps, doscientoslps, quinientoslps;
        int totaldos, totalcinco, totaldiez, totalveinte, totalcincuenta, totalcien, totaldoscientos, totalquinientos;

        int unlpsc, doslpsc, cincolpsc, diezlpsc, veintelpsc, cincuentalpsc, cienlpsc, doscientoslpsc, quinientoslpsc;
        int totaldosc, totalcincoc, totaldiezc, totalveintec, totalcincuentac, totalcienc, totaldoscientosc, totalquinientosc;

        decimal cincoCent, diezCent, veinteCent, cincuentaCent;
        decimal cincoCentc, diezCentc, veinteCentc, cincuentaCentc;

        decimal suma_total_CierreDia;
        int Saldoi;
        decimal diferencia;
        decimal totalcincoCent, totaldiezCent, totalveinteCent, totalcincuentaCent;

        private void cmbSaldoInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblsaldoid.Text=Convert.ToString(cmbSaldoInicial.SelectedValue);
        }

        int sumaBilletes, sumaBilletesc;
        decimal sumaCentavos, sumaCentavosc;

        decimal suma_total_Saldoi, suma_total_Saldoic;
       
        decimal totalcincoCentc, totaldiezCentc, totalveinteCentc, totalcincuentaCentc;
        public FrmCierreDiaInsert()
        {
            string usuario;
            int usuarioid;
            InitializeComponent();
            db = new FlujoDeCajaEntities();
            controller = new CierreDiaController();
            SI();
            usuario = UsuarioLog.UsuarioNombre;
            lblusuario.Text = usuario;
            lblIdCaja.Text = UsuarioLog.CajaId;
            lblCajaNumero.Text = UsuarioLog.CajaNumero;
            usuarioid=UsuarioLog.UsuarioId;
            lblusuarioid.Text = Convert.ToString(usuarioid);
            btnGuardar.Enabled = false;
            txt1L.Text = "0";
            txt2L.Text = "0";
            txt5L.Text = "0";
            txt10L.Text = "0";
            txt20L.Text = "0";
            txt50L.Text = "0";
            txt100L.Text = "0";
            txt200L.Text = "0";
            txt500L.Text = "0";
            txt5C.Text = "0";
            txt10C.Text = "0";
            txt20C.Text = "0";
            txt50C.Text = "0";

        }

        private void txt2L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt5L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt10L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt20L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt50L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt100L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt200L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        private void totales()
        {
            if (txt1L == null && txt1LCaja == null)
            {
                txt1L.Text = "0";

                unlps = Convert.ToInt32(txt1L.Text);

                txt1LCaja.Text = "0";

                unlpsc = Convert.ToInt32(txt1LCaja.Text);

            }
            else if (txt1L != null && txt1LCaja != null)
            {

                unlps = Convert.ToInt32(txt1L.Text);
                unlpsc = Convert.ToInt32(txt1LCaja.Text);

            }

            if (txt2L != null && txt2LCaja != null)
            {
                doslps = Convert.ToInt32(txt2L.Text);
                totaldos = doslps * 2;
                doslpsc = Convert.ToInt32(txt2LCaja.Text);
                totaldosc = doslpsc * 2;

            }

            if (txt5L != null && txt5LCaja != null)
            {
                cincolps = Convert.ToInt32(txt5L.Text);
                totalcinco = cincolps * 5;
                cincolpsc = Convert.ToInt32(txt5LCaja.Text);
                totalcincoc = cincolpsc * 5;

            }

            if (txt10L != null && txt10LCaja != null)
            {
                diezlps = Convert.ToInt32(txt10L.Text);
                totaldiez = diezlps * 10;
                diezlpsc = Convert.ToInt32(txt10LCaja.Text);
                totaldiezc = diezlpsc * 10;

            }

            if (txt20L != null && txt20LCaja != null)
            {
                veintelps = Convert.ToInt32(txt20L.Text);
                totalveinte = veintelps * 20;
                veintelpsc = Convert.ToInt32(txt20LCaja.Text);
                totalveintec = veintelpsc * 20;

            }

            if (txt50L != null && txt50LCaja != null)
            {
                cincuentalps = Convert.ToInt32(txt50L.Text);
                totalcincuenta = cincuentalps * 50;
                cincuentalpsc = Convert.ToInt32(txt50LCaja.Text);
                totalcincuentac = cincuentalpsc * 50;

            }

            if (txt100L != null && txt100LCaja != null)
            {
                cienlps = Convert.ToInt32(txt100L.Text);
                totalcien = cienlps * 100;
                cienlpsc = Convert.ToInt32(txt100LCaja.Text);
                totalcienc = cienlpsc * 100;

            }

            if (txt200L != null && txt200LCaja != null)
            {
                doscientoslps = Convert.ToInt32(txt200L.Text);
                totaldoscientos = doscientoslps * 200;
                doscientoslpsc = Convert.ToInt32(txt200LCaja.Text);
                totaldoscientosc = doscientoslpsc * 200;

            }

            if (txt500L != null && txt500LCaja != null)
            {
                quinientoslps = Convert.ToInt32(txt500L.Text);
                totalquinientos = quinientoslps * 500;
                quinientoslpsc = Convert.ToInt32(txt500LCaja.Text);
                totalquinientosc = quinientoslpsc * 500;

            }


            if (txt5C != null && txt5CCaja != null)
            {
                cincoCent = Convert.ToDecimal(txt5C.Text);
                totalcincoCent = (cincoCent / 20);
                cincoCentc = Convert.ToDecimal(txt5CCaja.Text);
                totalcincoCentc = (cincoCentc / 20);

            }

            if (txt10C != null && txt10CCaja != null)
            {
                diezCent = Convert.ToDecimal(txt10C.Text);
                totaldiezCent = (diezCent / 10);
                diezCentc = Convert.ToDecimal(txt10CCaja.Text);
                totaldiezCentc = (diezCentc / 10);

            }

            if (txt20C != null && txt20CCaja != null)
            {
                veinteCent = Convert.ToDecimal(txt20C.Text);
                totalveinteCent = (veinteCent / 5);
                veinteCentc = Convert.ToDecimal(txt20CCaja.Text);
                totalveinteCentc = (veinteCentc / 5);

            }

            if (txt50C != null && txt50CCaja != null)
            {
                cincuentaCent = Convert.ToDecimal(txt50C.Text);
                totalcincuentaCent = (cincuentaCent / 2);
                cincuentaCentc = Convert.ToDecimal(txt50CCaja.Text);
                totalcincuentaCentc = (cincuentaCentc / 2);

            }

            sumaBilletes = unlps + totaldos + totalcinco + totaldiez + totalveinte + totalcincuenta +
                            totalcien + totaldoscientos + totalquinientos;
            sumaCentavos = totalcincoCent + totaldiezCent + totalveinteCent + totalcincuentaCent;
            suma_total_Saldoi = sumaBilletes + sumaCentavos;

            txtTotalsaldoi.Text = suma_total_Saldoi.ToString();
            txtTotalBilletes.Text = sumaBilletes.ToString();
            txtTotalMonedas.Text = sumaCentavos.ToString();

            sumaBilletesc = unlpsc + totaldosc + totalcincoc + totaldiezc + totalveintec + totalcincuentac +
                          totalcienc + totaldoscientosc + totalquinientosc;
            sumaCentavosc = totalcincoCentc + totaldiezCentc + totalveinteCentc + totalcincuentaCentc;
            suma_total_Saldoic = sumaBilletesc + sumaCentavosc;

            txtTotalCaja.Text = suma_total_Saldoic.ToString();
            txtTotalBilletesCaja.Text = sumaBilletesc.ToString();
            txtTotalMonedasCaja.Text = sumaCentavosc.ToString();
        }
        private void FrmCierreDiaInsert_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT CajaSaldoTotal,CajaCantidadUnlps,CajaCantidadDoslps,CajaCantidadCincolps,CajaCantidadDiezlps,CajaCantidadVeintelps,CajaCantidadCincuentalps,CajaCantidadCienlps,CajaCantidadDoscientoslps,CajaCantidadQuinientos,CajaCantidadCincocent,CajaCantidadDiezcent,CajaCantidadVeintecent,CajaCantidadCincuentacent FROM Caja WHERE CajaId = @id";
            SqlConnection conn = new SqlConnection("data source=DESKTOP-MP6SVTR;initial catalog=FlujoDeCaja;persist security info=True;user id=sa;password=1234;MultipleActiveResultSets=True");
            {
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                command.Parameters.AddWithValue("@id", lblIdCaja.Text);
                //string codmax = Convert.ToString(command.ExecuteScalar());
                //int cod = Convert.ToInt32(codmax);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read() == true)
                {
                    txtTotalCaja.Text = reader["CajaSaldoTotal"].ToString();
                    txt1LCaja.Text = reader["CajaCantidadUnlps"].ToString();
                    txt2LCaja.Text = reader["CajaCantidadDoslps"].ToString();
                    txt5LCaja.Text = reader["CajaCantidadCincolps"].ToString();
                    txt10LCaja.Text = reader["CajaCantidadDiezlps"].ToString();
                    txt20LCaja.Text = reader["CajaCantidadVeintelps"].ToString();
                    txt50LCaja.Text = reader["CajaCantidadCincuentalps"].ToString();
                    txt100LCaja.Text = reader["CajaCantidadCienlps"].ToString();
                    txt200LCaja.Text = reader["CajaCantidadDoscientoslps"].ToString();
                    txt500LCaja.Text = reader["CajaCantidadQuinientos"].ToString();

                    txt5CCaja.Text = reader["CajaCantidadCincocent"].ToString();
                    txt10CCaja.Text = reader["CajaCantidadDiezcent"].ToString();
                    txt20CCaja.Text = reader["CajaCantidadVeintecent"].ToString();
                    txt50CCaja.Text = reader["CajaCantidadCincuentacent"].ToString();


                }



            }
        }

        private void txt1L_Leave(object sender, EventArgs e)
        {
            if (txt1L.Text == "")
            {
                txt1L.Text = "0";
            }
        }

        private void txt2L_Leave(object sender, EventArgs e)
        {
            if (txt2L.Text == "")
            {
                txt2L.Text = "0";
            }
        }

        private void txt5L_Leave(object sender, EventArgs e)
        {
            if (txt5L.Text == "")
            {
                txt5L.Text = "0";
            }
        }

        private void txt10L_Leave(object sender, EventArgs e)
        {
            if (txt10L.Text == "")
            {
                txt10L.Text = "0";
            }
        }

        private void txt20L_Leave(object sender, EventArgs e)
        {
            if (txt20L.Text == "")
            {
                txt20L.Text = "0";
            }
        }

        private void txt50L_Leave(object sender, EventArgs e)
        {
            if (txt50L.Text == "")
            {
                txt50L.Text = "0";
            }
        }

        private void txt100L_Leave(object sender, EventArgs e)
        {
            if (txt100L.Text == "")
            {
                txt100L.Text = "0";
            }
        }

        private void txt200L_Leave(object sender, EventArgs e)
        {
            if (txt200L.Text == "")
            {
                txt200L.Text = "0";
            }
        }

        private void txt500L_Leave(object sender, EventArgs e)
        {
            if (txt500L.Text == "")
            {
                txt500L.Text = "0";
            }
        }

        private void txt5C_Leave(object sender, EventArgs e)
        {
            if (txt5C.Text == "")
            {
                txt5C.Text = "0";
            }
        }

        private void txt10C_Leave(object sender, EventArgs e)
        {
            if (txt10C.Text == "")
            {
                txt10C.Text = "0";
            }
        }

        private void txt20C_Leave(object sender, EventArgs e)
        {
            if (txt20C.Text == "")
            {
                txt20C.Text = "0";
            }
        }

        private void txt50C_Leave(object sender, EventArgs e)
        {
            if (txt50C.Text == "")
            {
                txt50C.Text = "0";
            }
        }

        private void txt500L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt5C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt10C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt20C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt50C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt1L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        public readonly FlujoDeCajaEntities db;

        SaldosInicialesController saldoInicial = new SaldosInicialesController();
        private void SI()
        {
            cmbSaldoInicial.DataSource = saldoInicial.GetSaldosIniciales(cmbSaldoInicial.Text);
            cmbSaldoInicial.DisplayMember = "SaldoInicialTotal";
            cmbSaldoInicial.ValueMember = "SaldoInicial_Id";

        }

        

        private void btnsumar_Click(object sender, EventArgs e)
        {
            totales();

            btnGuardar.Enabled = true;
        }

        private void txt2L_Click(object sender, EventArgs e)
        {
            txt2L.Text = "";

        }

        private void txt5L_Click(object sender, EventArgs e)
        {
            txt5L.Text = "";
        }

        private void txt10L_Click(object sender, EventArgs e)
        {
            txt10L.Text = "";
        }

        private void txt20L_Click(object sender, EventArgs e)
        {
            txt20L.Text = "";
        }

        private void txt100L_Click(object sender, EventArgs e)
        {
            txt100L.Text = "";
        }

        private void txt200L_Click(object sender, EventArgs e)
        {
            txt200L.Text = "";
        }

        private void txt500L_Click(object sender, EventArgs e)
        {
            txt500L.Text = "";
        }

        private void txt50L_Click(object sender, EventArgs e)
        {
            txt50L.Text = "";
        }

        private void txt1L_Click(object sender, EventArgs e)
        {
            txt1L.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Multi_TornillosDAL.CierreDias cierreDia = new Multi_TornillosDAL.CierreDias
            {
                CierreDiaTotal = Convert.ToDecimal(txtdiferencia.Text),
                CierreDiaFecha = DateTime.Now,
                SaldoInicial_Id =Convert.ToInt32(lblsaldoid.Text),
                UsuarioId = Convert.ToInt32(lblusuarioid.Text),
                CajaId = Convert.ToInt32( lblIdCaja.Text)

            };
            if (controller.Add(cierreDia))
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
