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
using Multi_Tornillos;
using System.Data.SqlClient;
using Multi_Tornillos.Views;
namespace Multi_Tornillos.Views.Transacciones.Retiros
{
    public partial class FrmRetirosInsert : Form
    {
        private readonly RetirosController controller;
        private readonly FlujoDeCajaEntities db;

        int unlps, doslps, cincolps, diezlps, veintelps, cincuentalps, cienlps, doscientoslps, quinientoslps;
        int totaldos, totalcinco, totaldiez, totalveinte, totalcincuenta, totalcien, totaldoscientos, totalquinientos;
        decimal cincoCent, diezCent, veinteCent, cincuentaCent;
        decimal suma_total_Saldoi;
        decimal totalcincoCent, totaldiezCent, totalveinteCent, totalcincuentaCent;

        private void FrmRetirosInsert_Load_1(object sender, EventArgs e)
        {
            txtCajaId.Text = UsuarioLog.CajaId;
        }

        int decidido =UsuarioLog.decision;
        

        int sumaBilletes;
        decimal sumaCentavos;
        public string idcaja;
        public FrmRetirosInsert()
        {
            string usuario;
            InitializeComponent();
            controller = new RetirosController();
            db = new FlujoDeCajaEntities();
            usuario = UsuarioLog.UsuarioNombre;
            label6.Text =Convert.ToString( DateTime.Now);
            lblusuario.Text = usuario;
            lblCajaNumero.Text = UsuarioLog.CajaNumero;
            lblIdCaja.Text = UsuarioLog.CajaId;

            datos_de_inicio();
            
        }

        private void datos_de_inicio()
        {
            
                if (decidido==1)
                {
                txt1L.Text = CacheDineroRetiro.RetiroCantidadUnlps.ToString();
                txt2L.Text = CacheDineroRetiro.RetiroCantidadDoslps.ToString();
                txt5L.Text = CacheDineroRetiro.RetiroCantidadCincolps.ToString();
                txt10L.Text = CacheDineroRetiro.RetiroCantidadDiezlps.ToString();
                txt20L.Text = CacheDineroRetiro.RetiroCantidadVeintelps.ToString();
                txt50L.Text = CacheDineroRetiro.RetiroCantidadCincuentalps.ToString();
                txt100L.Text = CacheDineroRetiro.RetiroCantidadCienlps.ToString();
                txt200L.Text = CacheDineroRetiro.RetiroCantidadDoscientoslps.ToString();
                txt500L.Text = CacheDineroRetiro.RetiroCantidadQuinientos.ToString();
                txt5C.Text = CacheDineroRetiro.RetiroCantidadCincocent.ToString();
                txt10C.Text = CacheDineroRetiro.RetiroCantidadDiezcent.ToString();
                txt20C.Text = CacheDineroRetiro.RetiroCantidadVeintecent.ToString();
                txt50C.Text = CacheDineroRetiro.RetiroCantidadCincuentacent.ToString();

            }
                else if(decidido==0)
                {
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

            
            
        }

        private void FrmRetirosInsert_Load(object sender, EventArgs e)
        {
            lblIdCaja.Text = UsuarioLog.CajaId;
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
            string mensaje = "Esta seguro de cancelar esta operacion?";
            string cancelar = "Cancelando";
            MessageBoxButtons opcion = MessageBoxButtons.OKCancel;
            DialogResult mbx;
            mbx = MessageBox.Show(mensaje, cancelar, opcion);

            if (mbx == System.Windows.Forms.DialogResult.OK)
            {
                string mnsj = "Guardar Datos?";
                string cancel = "Datos";
                MessageBoxButtons op = MessageBoxButtons.YesNo;
                DialogResult guardardatos;
                guardardatos = MessageBox.Show(mnsj, cancel, op);
                if (guardardatos == System.Windows.Forms.DialogResult.Yes)
                {
                    decidido= Convert.ToInt32(1);
                    CacheDineroRetiro.RetiroDescripcion = txtDescripcion.Text;
                    CacheDineroRetiro.RetiroCantidadUnlps = Convert.ToInt32(txt1L.Text);
                    CacheDineroRetiro.RetiroCantidadDoslps = Convert.ToInt32(txt2L.Text);
                    CacheDineroRetiro.RetiroCantidadCincolps = Convert.ToInt32(txt5L.Text);
                    CacheDineroRetiro.RetiroCantidadDiezlps = Convert.ToInt32(txt10L.Text);
                    CacheDineroRetiro.RetiroCantidadVeintelps = Convert.ToInt32(txt20L.Text);
                    CacheDineroRetiro.RetiroCantidadCincuentalps = Convert.ToInt32(txt50L.Text);
                    CacheDineroRetiro.RetiroCantidadCienlps = Convert.ToInt32(txt100L.Text);
                    CacheDineroRetiro.RetiroCantidadDoscientoslps = Convert.ToInt32(txt200L.Text);
                    CacheDineroRetiro.RetiroCantidadQuinientos = Convert.ToInt32(txt500L.Text);
                    CacheDineroRetiro.RetiroCantidadCincocent = Convert.ToInt32(txt5C.Text);
                    CacheDineroRetiro.RetiroCantidadDiezcent = Convert.ToInt32(txt10C.Text);
                    CacheDineroRetiro.RetiroCantidadVeintecent = Convert.ToInt32(txt20C.Text);
                    CacheDineroRetiro.RetiroCantidadCincuentacent = Convert.ToInt32(txt50C.Text);
                    UsuarioLog.decision = decidido;
                    this.Close();
                }
                else if (guardardatos == System.Windows.Forms.DialogResult.No)
                {
                    decidido =Convert.ToInt32(0);
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
                    UsuarioLog.decision = decidido;
                    this.Close();
                }

            }
            else if (mbx == System.Windows.Forms.DialogResult.Cancel)
            {

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var RetiroId = db.Caja.ToList().Select(d => d.CajaId).Max();


            var saldo = db.Caja.Find(int.Parse(txtCajaId.Text));

            if ((Convert.ToDecimal(txtTotalsaldoi.Text) > saldo.CajaSaldoTotal) || (Convert.ToDecimal(txt1L.Text) > saldo.CajaCantidadUnlps
                || Convert.ToDecimal(txt2L.Text) > saldo.CajaCantidadDoslps || Convert.ToDecimal(txt5L.Text) > saldo.CajaCantidadCincolps
                || Convert.ToDecimal(txt10L.Text) > saldo.CajaCantidadDiezlps || Convert.ToDecimal(txt20L.Text) > saldo.CajaCantidadVeintelps
                || Convert.ToDecimal(txt50L.Text) > saldo.CajaCantidadCincuentalps || Convert.ToDecimal(txt100L.Text) > saldo.CajaCantidadCienlps
                || Convert.ToDecimal(txt200L.Text) > saldo.CajaCantidadDoscientoslps || Convert.ToDecimal(txt500L.Text) > saldo.CajaCantidadQuinientos
                || Convert.ToDecimal(txt5C.Text) > saldo.CajaCantidadCincocent || Convert.ToDecimal(txt10C.Text) > saldo.CajaCantidadDiezcent
                || Convert.ToDecimal(txt20C.Text) > saldo.CajaCantidadVeintecent || Convert.ToDecimal(txt50C.Text) > saldo.CajaCantidadCincuentacent))
            {
                MessageBox.Show("Error no puede retirar esa cantidad");
                
            }
            else
            {
                Multi_TornillosDAL.Retiros retiro = new Multi_TornillosDAL.Retiros
                {
                    RetiroSaldoTotal = Convert.ToDecimal(txtTotalsaldoi.Text),
                    RetiroDescripcion = txtDescripcion.Text,
                    RetiroFecha = DateTime.Now,
                    RetiroCantidadUnlps = Convert.ToInt32(txt1L.Text),
                    RetiroCantidadDoslps = Convert.ToInt32(txt2L.Text),
                    RetiroCantidadCincolps = Convert.ToInt32(txt5L.Text),
                    RetiroCantidadDiezlps = Convert.ToInt32(txt10L.Text),
                    RetiroCantidadVeintelps = Convert.ToInt32(txt20L.Text),
                    RetiroCantidadCincuentalps = Convert.ToInt32(txt50L.Text),
                    RetiroCantidadCienlps = Convert.ToInt32(txt100L.Text),
                    RetiroCantidadDoscientoslps = Convert.ToInt32(txt200L.Text),
                    RetiroCantidadQuinientos = Convert.ToInt32(txt500L.Text),
                    RetiroCantidadCincocent = Convert.ToInt32(txt5C.Text),
                    RetiroCantidadDiezcent = Convert.ToInt32(txt10C.Text),
                    RetiroCantidadVeintecent = Convert.ToInt32(txt20C.Text),
                    RetiroCantidadCincuentacent = Convert.ToInt32(txt50C.Text),
                    UsuarioId = Convert.ToInt32(UsuarioLog.UsuarioId),
                    CajaId = Convert.ToInt32(lblIdCaja.Text)
                };
                Multi_TornillosDAL.Caja caja = new Multi_TornillosDAL.Caja
                {
                    CajaSaldoTotal = Convert.ToDecimal(txtTotalsaldoi.Text) - retiro.RetiroSaldoTotal,
                    CajaCantidadUnlps = Convert.ToInt32(txt1L.Text) - retiro.RetiroCantidadUnlps,
                    CajaCantidadDoslps = Convert.ToInt32(txt2L.Text) - retiro.RetiroCantidadDoslps,
                    CajaCantidadCincolps = Convert.ToInt32(txt5L.Text) - retiro.RetiroCantidadCincolps,
                    CajaCantidadDiezlps = Convert.ToInt32(txt10L.Text) - retiro.RetiroCantidadDiezlps,
                    CajaCantidadVeintelps = Convert.ToInt32(txt20L.Text) - retiro.RetiroCantidadVeintelps,
                    CajaCantidadCincuentalps = Convert.ToInt32(txt50L.Text) - retiro.RetiroCantidadCincuentalps,
                    CajaCantidadCienlps = Convert.ToInt32(txt100L.Text) - retiro.RetiroCantidadCienlps,
                    CajaCantidadDoscientoslps = Convert.ToInt32(txt200L.Text) - retiro.RetiroCantidadDoscientoslps,
                    CajaCantidadQuinientos = Convert.ToInt32(txt500L.Text) - retiro.RetiroCantidadQuinientos,
                    CajaCantidadCincocent = Convert.ToInt32(txt5C.Text) - retiro.RetiroCantidadCincocent,
                    CajaCantidadDiezcent = Convert.ToInt32(txt10C.Text) - retiro.RetiroCantidadDiezcent,
                    CajaCantidadVeintecent = Convert.ToInt32(txt20C.Text) - retiro.RetiroCantidadVeintecent,
                    CajaCantidadCincuentacent = Convert.ToInt32(txt50C.Text) - retiro.RetiroCantidadCincuentacent
                };

               
                //Actualizar el saldo del cliente al que se le retiro

                saldo.CajaSaldoTotal = saldo.CajaSaldoTotal - Convert.ToDecimal(txtTotalsaldoi.Text);
                saldo.CajaCantidadUnlps = saldo.CajaCantidadUnlps - Convert.ToInt32(txt1L.Text);
                saldo.CajaCantidadDoslps = saldo.CajaCantidadDoslps - Convert.ToInt32(txt2L.Text);
                saldo.CajaCantidadCincolps = saldo.CajaCantidadCincolps - Convert.ToInt32(txt5L.Text);
                saldo.CajaCantidadDiezlps = saldo.CajaCantidadDiezlps - Convert.ToInt32(txt10L.Text);
                saldo.CajaCantidadVeintelps = saldo.CajaCantidadVeintelps - Convert.ToInt32(txt20L.Text);
                saldo.CajaCantidadCincuentalps = saldo.CajaCantidadCincuentalps - Convert.ToInt32(txt50L.Text);
                saldo.CajaCantidadCienlps = saldo.CajaCantidadCienlps - Convert.ToInt32(txt100L.Text);
                saldo.CajaCantidadDoscientoslps = saldo.CajaCantidadDoscientoslps - Convert.ToInt32(txt200L.Text);
                saldo.CajaCantidadQuinientos = saldo.CajaCantidadQuinientos - Convert.ToInt32(txt500L.Text);
                saldo.CajaCantidadCincocent = saldo.CajaCantidadCincocent - Convert.ToInt32(txt5C.Text);
                saldo.CajaCantidadDiezcent = saldo.CajaCantidadDiezcent - Convert.ToInt32(txt10C.Text);
                saldo.CajaCantidadVeintecent = saldo.CajaCantidadVeintecent - Convert.ToInt32(txt20C.Text);
                saldo.CajaCantidadCincuentacent = saldo.CajaCantidadCincuentacent - Convert.ToInt32(txt50C.Text);

                db.Entry(saldo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ////Reducir el monto del cliente que retiro

                //var saldo2 = db.Cliente.Find(int.Parse(txtClienteId2.Text));

                //saldo2.ClienteSaldo = saldo2.ClienteSaldo - Convert.ToDecimal(txtMonto.Text);

                //db.Entry(saldo2).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                if (controller.Add(retiro))
                {
                    MessageBox.Show("Retiro ingresado correctamente");
                    controller.Dispose();
                    this.Dispose();
                    saldo.CajaSaldoTotal = CacheDinero.CajaSaldoTotal;
                }
                else
                {
                    MessageBox.Show("Error para agregar");
                }
            }

            //public void MaxId()
            //{
            //    FrmMenu frmMenu = new FrmMenu();
            //    string sql = @"SELECT TOP 1 CajaSaldoTotal FROM Caja WHERE CajaSaldoTotal = CajaSaldoTotal ORDER BY CajaSaldoTotal DESC";
            //    using (SqlConnection conn = new SqlConnection("data source=DESKTOP-I3P9B28;initial catalog=FlujoDeCaja;persist security info=True;user id=sa;password=1234;MultipleActiveResultSets=True"))
            //    {
            //        SqlCommand command = new SqlCommand(sql, conn);
            //        conn.Open();
            //        string codmax = Convert.ToString(command.ExecuteScalar());
            //        int cod = Convert.ToInt32(codmax);
            //        frmMenu.txtSaldoCaja.Text = Convert.ToString(cod);
            //    }
            //}

        }




    }
}
