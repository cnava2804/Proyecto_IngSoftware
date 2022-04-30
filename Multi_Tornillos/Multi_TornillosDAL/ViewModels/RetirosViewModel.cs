using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
    public class RetirosViewModel
    {
        [DisplayName("Id")]
        public int Retiro_Id { get; set; }
        [DisplayName("Descripcion")]

        public string RetiroDescripcion { get; set; }

        [DisplayName("Fecha de Creacion")]
        public DateTime RetiroFecha { get; set; }
        [DisplayName("Saldo Total")]
        public decimal RetiroSaldoTotal { get; set; }
        [DisplayName("Cantidad 1L")]
        public int RetiroCantidadUnlps { get; set; }
        [DisplayName("Cantidad 2L")]
        public int RetiroCantidadDoslps { get; set; }
        [DisplayName("Cantidad 5L")]
        public int RetiroCantidadCincolps { get; set; }
        [DisplayName("Cantidad 10L")]
        public int RetiroCantidadDiezlps { get; set; }
        [DisplayName("Cantidad 20L")]
        public int RetiroCantidadVeintelps { get; set; }
        [DisplayName("Cantidad 50L")]
        public int RetiroCantidadCincuentalps { get; set; }
        [DisplayName("Cantidad 100L")]
        public int RetiroCantidadCienlps { get; set; }
        [DisplayName("Cantidad 200L")]
        public int RetiroCantidadDoscientoslps { get; set; }
        [DisplayName("Cantidad 500L")]
        public int RetiroCantidadQuinientos { get; set; }
        [DisplayName("Cantidad 5cnt")]
        public int RetiroCantidadCincocent { get; set; }
        [DisplayName("Cantidad 10cnt")]
        public int RetiroCantidadDiezcent { get; set; }
        [DisplayName("Cantidad 20cnt")]
        public int RetiroCantidadVeintecent { get; set; }
        [DisplayName("Cantidad 50cnt")]
        public int RetiroCantidadCincuentacent { get; set; }

        [Browsable(false)]
        public decimal OperacionRetiro
        {
            get
            {
                return CajaSaldoTotal = CajaSaldoTotal - RetiroSaldoTotal;
            }
        }

        [Browsable(false)]
        public Nullable<int> SaldoInicial_Id { get; set; }

        [Browsable(false)]
        public Nullable<int> UsuarioId { get; set; }

        [Browsable(false)]
        public Nullable<int> CajaId { get; set; }

        [Browsable(false)]
        public decimal CajaSaldoTotal { get; set; }

        [Browsable(false)]
        public virtual SaldosIniciales SaldosIniciales { get; set; }

        [Browsable(false)]
        public virtual Usuario Usuario { get; set; }

        [Browsable(false)]
        public virtual Caja Caja { get; set; }
    }
}
