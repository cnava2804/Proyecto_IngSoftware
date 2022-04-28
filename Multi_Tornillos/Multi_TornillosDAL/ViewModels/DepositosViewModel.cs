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

        public string DepositoDescripcion { get; set; }

        [DisplayName("Fecha de Creacion")]
        public DateTime DepositoFecha { get; set; }

        public decimal DepositoSaldoTotal { get; set; }

        public int DepositoCantidadUnlps { get; set; }
        public int DepositoCantidadDoslps { get; set; }
        public int DepositoCantidadCincolps { get; set; }
        public int DepositoCantidadDiezlps { get; set; }
        public int DepositoCantidadVeintelps { get; set; }
        public int DepositoCantidadCincuentalps { get; set; }
        public int DepositoCantidadCienlps { get; set; }
        public int DepositoCantidadDoscientoslps { get; set; }
        public int DepositoCantidadQuinientos { get; set; }
        public int DepositoCantidadCincocent { get; set; }
        public int DepositoCantidadDiezcent { get; set; }
        public int DepositoCantidadVeintecent { get; set; }
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
