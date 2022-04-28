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

        public string RetiroDescripcion { get; set; }

        [DisplayName("Fecha de Creacion")]
        public DateTime RetiroFecha { get; set; }

        public decimal RetiroSaldoTotal { get; set; }

        public int RetiroCantidadUnlps { get; set; }
        public int RetiroCantidadDoslps { get; set; }
        public int RetiroCantidadCincolps { get; set; }
        public int RetiroCantidadDiezlps { get; set; }
        public int RetiroCantidadVeintelps { get; set; }
        public int RetiroCantidadCincuentalps { get; set; }
        public int RetiroCantidadCienlps { get; set; }
        public int RetiroCantidadDoscientoslps { get; set; }
        public int RetiroCantidadQuinientos { get; set; }
        public int RetiroCantidadCincocent { get; set; }
        public int RetiroCantidadDiezcent { get; set; }
        public int RetiroCantidadVeintecent { get; set; }
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
