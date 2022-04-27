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
using Multi_TornillosDAL;

namespace Multi_Tornillos.Views.Transacciones.Depositos
{
    public partial class FrmDepositosInsert : Form
    {
        private readonly DepositosController controller;
        private readonly FlujoDeCajaEntities db; 
        int unlps, doslps, cincolps, diezlps, veintelps, cincuentalps, cienlps, doscientoslps, quinientoslps;
        int totaldos, totalcinco, totaldiez, totalveinte, totalcincuenta, totalcien, totaldoscientos, totalquinientos;
        decimal cincoCent, diezCent, veinteCent, cincuentaCent;
        decimal suma_total_Saldoi;
        decimal totalcincoCent, totaldiezCent, totalveinteCent, totalcincuentaCent;

        private void cmbSaldoInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblvalue.Text = Convert.ToString(cmbSaldoInicial.SelectedValue);
        }

        private void cmbSaldoInicial_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        SaldosInicialesController saldoInicial = new SaldosInicialesController();
        public void SI()
        {
            cmbSaldoInicial.DataSource = saldoInicial.GetSaldosIniciales(cmbSaldoInicial.Text);
            cmbSaldoInicial.DisplayMember = "SaldoInicialTotal";
            cmbSaldoInicial.ValueMember = "SaldoInicial_Id";
        }

        int sumaBilletes;
        decimal sumaCentavos;
        public string idcaja;
        public FrmDepositosInsert()
        {
            string usuario;
            InitializeComponent();
            controller = new DepositosController();
            usuario = UsuarioLog.UsuarioNombre;
            label6.Text =Convert.ToString( DateTime.Now);
            lblusuario.Text = usuario;
            cmbSaldoInicial.SelectedValue = 0;
            SI();
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

        private void FrmDepositosInsert_Load(object sender, EventArgs e)
        {
            lblIdCaja.Text = idcaja;
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
            else if (txt1L != null)
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
                totalcincoCent = (cincoCent / 20);
            }

            if (txt10C != null)
            {
                diezCent = Convert.ToDecimal(txt10C.Text);
                totaldiezCent = (diezCent / 10);
            }

            if (txt20C != null)
            {
                veinteCent = Convert.ToDecimal(txt20C.Text);
                totalveinteCent = (veinteCent / 5);
            }

            if (txt50C != null)
            {
                cincuentaCent = Convert.ToDecimal(txt50C.Text);
                totalcincuentaCent = (cincuentaCent / 2);
            }
            sumaBilletes = unlps + totaldos + totalcinco + totaldiez + totalveinte + totalcincuenta +
                            totalcien + totaldoscientos + totalquinientos;
            sumaCentavos = totalcincoCent + totaldiezCent + totalveinteCent + totalcincuentaCent;
            suma_total_Saldoi = sumaBilletes + sumaCentavos;

            txtTotalsaldoi.Text = suma_total_Saldoi.ToString();
            txtTotalBilletes.Text = sumaBilletes.ToString();
            txtTotalMonedas.Text = sumaCentavos.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Multi_TornillosDAL.Depositos deposito = new Multi_TornillosDAL.Depositos
            {
                DepositoSaldoTotal = Convert.ToDecimal(txtTotalsaldoi.Text),
                DepositoDescripcion = txtDescripcion.Text,
                DepositoFecha = DateTime.Now,
                DepositoCantidadUnlps = Convert.ToInt32(txt1L.Text),
                DepositoCantidadDoslps = Convert.ToInt32(txt2L.Text),
                DepositoCantidadCincolps = Convert.ToInt32(txt5L.Text),
                DepositoCantidadDiezlps = Convert.ToInt32(txt10L.Text),
                DepositoCantidadVeintelps = Convert.ToInt32(txt20L.Text),
                DepositoCantidadCincuentalps = Convert.ToInt32(txt50L.Text),
                DepositoCantidadCienlps = Convert.ToInt32(txt100L.Text),
                DepositoCantidadDoscientoslps = Convert.ToInt32(txt200L.Text),
                DepositoCantidadQuinientos = Convert.ToInt32(txt500L.Text),
                DepositoCantidadCincocent = Convert.ToInt32(txt5C.Text),
                DepositoCantidadDiezcent = Convert.ToInt32(txt10C.Text),
                DepositoCantidadVeintecent = Convert.ToInt32(txt20C.Text),
                DepositoCantidadCincuentacent = Convert.ToInt32(txt50C.Text),
                UsuarioId = Convert.ToInt32(UsuarioLog.UsuarioId),
                CajaId = Convert.ToInt32(lblIdCaja.Text),
                SaldoInicial_Id = Convert.ToInt32(lblvalue.Text)


            };

            //var DepositoId = db.SaldosIniciales.ToList().Select(d => d.SaldoInicial_Id).Max();

            //var saldo = db.SaldosIniciales.Find(int.Parse(txtTotalsaldoi.Text));
            ////Actualizar el saldo del cliente al que se le deposito
            //saldo.ClienteSaldo = saldo.ClienteSaldo + Convert.ToDecimal(txtTotalsaldoi.Text);

            //db.Entry(saldo).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();

            if (controller.Add(deposito))
            {
                MessageBox.Show("Deposito ingresado correctamente");
                controller.Dispose();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Error para agregar");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


    }
}
