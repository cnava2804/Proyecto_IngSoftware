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

namespace Multi_Tornillos.Views.CierreDia
{
    public partial class FrmCierreDiaInsert : Form
    {
        private readonly CierreDiaController controller;
        int unlps, doslps, cincolps, diezlps, veintelps, cincuentalps, cienlps, doscientoslps, quinientoslps;
        int totaldos, totalcinco, totaldiez, totalveinte, totalcincuenta, totalcien, totaldoscientos, totalquinientos;
        decimal cincoCent, diezCent, veinteCent, cincuentaCent;
        decimal suma_total_CierreDia;
        int Saldoi;
        decimal ganancia;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Multi_TornillosDAL.CierreDias cierreDia = new Multi_TornillosDAL.CierreDias
            //{
            //    SaldoInicialTotal = Convert.ToDecimal(txtTotalsaldoi.Text),
            //    SaldoInicialFecha = DateTime.Now,
            //    UsuarioId = UsuarioLog.UsuarioId
               
            //};
            //if (controller.Add(cierreDia))
            //{
            //    MessageBox.Show("ingresado correctamente");
            //    controller.Dispose();
            //    this.Dispose();

            //}
            //else
            //{
            //    MessageBox.Show("Error para agregar");
            //}
        }

        decimal totalcincoCent, totaldiezCent, totalveinteCent, totalcincuentaCent;

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

        private void txtTotalBilletes_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void btnsumar_Click(object sender, EventArgs e)
        {
            if (txt1L == null)
            {
                txt1L.Text = "0";
                unlps = Convert.ToInt32(txt1L.Text);

            }
            else if(txt1L != null)
            {
                
                unlps = Convert.ToInt32(txt1L.Text);
            }

            if (txt2L != null)
            {
                doslps = Convert.ToInt32(txt2L.Text);
                totaldos = doslps * 2;
            }

            if (txt5L != null)
            {
                cincolps = Convert.ToInt32(txt5L.Text);
                totalcinco = cincolps * 5;
            }

            if (txt10L != null)
            {
                diezlps = Convert.ToInt32(txt10L.Text);
                totaldiez = diezlps * 10;
            }

            if (txt20L != null)
            {
                veintelps = Convert.ToInt32(txt20L.Text);
                totalveinte = veintelps * 20;
            }

            if (txt50L != null)
            {
                cincuentalps = Convert.ToInt32(txt50L.Text);
                totalcincuenta = cincuentalps * 50;
            }

            if (txt100L != null)
            {
                cienlps = Convert.ToInt32(txt100L.Text);
                totalcien = cienlps * 100;
            }

            if (txt200L != null)
            {
                doscientoslps = Convert.ToInt32(txt200L.Text);
                totaldoscientos = doscientoslps * 200;
            }

            if (txt500L != null)
            {
                quinientoslps = Convert.ToInt32(txt500L.Text);
                totalquinientos = quinientoslps * 500;
            }


            if (txt5C != null)
            {
                cincoCent = Convert.ToDecimal(txt5C.Text);
                totalcincoCent = (cincoCent/20);
            }

            if (txt10C != null)
            {
                diezCent = Convert.ToDecimal(txt10C.Text);
                totaldiezCent = (diezCent/10);
            }

            if (txt20C != null)
            {
                veinteCent = Convert.ToDecimal(txt20C.Text);
                totalveinteCent = (veinteCent/5);
            }

            if (txt50C != null)
            {
                cincuentaCent = Convert.ToDecimal(txt50C.Text);
                totalcincuentaCent = (cincuentaCent/2);
            }
            Saldoi = Convert.ToInt32(cmbSaldoInicial.Text);
            sumaBilletes = unlps + totaldos + totalcinco + totaldiez + totalveinte + totalcincuenta +
                            totalcien + totaldoscientos + totalquinientos;
            sumaCentavos = totalcincoCent + totaldiezCent + totalveinteCent + totalcincuentaCent;
            suma_total_CierreDia = sumaBilletes + sumaCentavos + Saldoi;

            txtTotalsaldoi.Text = suma_total_CierreDia.ToString();
            txtTotalBilletes.Text = sumaBilletes.ToString();
            txtTotalMonedas.Text = sumaCentavos.ToString();
        }

        int sumaBilletes;
        decimal sumaCentavos;
        public FrmCierreDiaInsert()
        {
            string usuario;

            InitializeComponent();
            controller = new CierreDiaController();
            SI();
            usuario = UsuarioLog.UsuarioNombre;
            lblusuario.Text = usuario;
            
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
            //SumatoriaBilletes();

            //SumatoriaTotalBilletes();
            //txtTotalBilletes.Text = sumaBilletes.ToString();

        }

        //private void SumatoriaTotalBilletes()
        //{
        //    sumaBilletes = unlps + totaldos + totalcinco + totaldiez;

        //}


        SaldosInicialesController saldoInicial = new SaldosInicialesController();
        private void SI()
        {
            cmbSaldoInicial.DataSource = saldoInicial.GetSaldosIniciales(cmbSaldoInicial.Text);
            cmbSaldoInicial.DisplayMember = "SaldoInicialTotal";
            cmbSaldoInicial.ValueMember = "SaldoInicialTotal";
        }
        public void SumatoriaBilletes()
        {
            if (txt1L != null)
            {
                unlps = Convert.ToInt32(txt1L.Text);

            }
            else
            {
                unlps = 0;
            }

            if (txt2L != null)
            {
                doslps = Convert.ToInt32(txt2L.Text);
                totaldos = doslps * 2;
            }

            if (txt5L != null)
            {
                cincolps = Convert.ToInt32(txt5L.Text);
                totalcinco = cincolps * 5;
            }

            if (txt10L != null)
            {
                diezlps = Convert.ToInt32(txt10L.Text);
                totaldiez = diezlps * 10;
            }

            if (txt20L != null)
            {
                veintelps = Convert.ToInt32(txt20L.Text);
                totalveinte = veintelps * 20;
            }

            if (txt50L != null)
            {
                cincuentalps = Convert.ToInt32(txt50L.Text);
                totalcincuenta = cincuentalps * 50;
            }

            if (txt100L != null)
            {
                cienlps = Convert.ToInt32(txt100L.Text);
                totalcien = cienlps * 100;
            }

            if (txt200L != null)
            {
                doscientoslps = Convert.ToInt32(txt200L.Text);
                totaldoscientos = doscientoslps * 200;
            }

            if (txt500L != null)
            {
                quinientoslps = Convert.ToInt32(txt500L.Text);
                totalquinientos = quinientoslps * 500;
            }
            sumaBilletes = unlps + totaldos + totalcinco + totaldiez + totalveinte + totalcincuenta +
                            totalcien + totaldoscientos + totalquinientos;
            txtTotalBilletes.Text = sumaBilletes.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


    }
}
