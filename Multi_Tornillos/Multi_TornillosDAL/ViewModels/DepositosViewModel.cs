using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
    public class DepositosViewModel
    {
        [DisplayName("Id")]
        public int Deposito_Id { get; set; }
        [DisplayName("Descripcion")]
        public string DepositoDescripcion { get; set; }

        [DisplayName("Fecha de Creacion")]
        public DateTime DepositoFecha { get; set; }
        [DisplayName("Saldo Total")]
        public decimal DepositoSaldoTotal { get; set; }
        [DisplayName("Cantidad 1L")]
        public int DepositoCantidadUnlps { get; set; }
        [DisplayName("Cantidad 2L")]
        public int DepositoCantidadDoslps { get; set; }
        [DisplayName("Cantidad 5L")]
        public int DepositoCantidadCincolps { get; set; }
        [DisplayName("Cantidad 10L")]
        public int DepositoCantidadDiezlps { get; set; }
        [DisplayName("Cantidad 20L")]
        public int DepositoCantidadVeintelps { get; set; }
        [DisplayName("Cantidad 50L")]
        public int DepositoCantidadCincuentalps { get; set; }
        [DisplayName("Cantidad 100L")]
        public int DepositoCantidadCienlps { get; set; }
        [DisplayName("Cantidad 200L")]
        public int DepositoCantidadDoscientoslps { get; set; }
        [DisplayName("Cantidad 500L")]
        public int DepositoCantidadQuinientos { get; set; }
        [DisplayName("Cantidad 5cnt")]
        public int DepositoCantidadCincocent { get; set; }
        [DisplayName("Cantidad 10cnt")]
        public int DepositoCantidadDiezcent { get; set; }
        [DisplayName("Cantidad 20cnt")]
        public int DepositoCantidadVeintecent { get; set; }
        [DisplayName("Cantidad 50cnt")]
        public int DepositoCantidadCincuentacent { get; set; }

        [Browsable(false)]
        public decimal OperacionDeposito
        {
            get
            {
                return CajaSaldoTotal += DepositoSaldoTotal;
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
