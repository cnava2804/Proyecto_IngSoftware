using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
    public class CajaViewModel
    {
        [DisplayName("Id")]
        public int CajaId { get; set; }

        [DisplayName("Num. Caja")]
        public string CajaNumero { get; set; }

        [DisplayName("Saldo Caja")]
        public decimal CajaSaldoTotal { get; set; }

        public int CajaCantidadUnlps { get; set; }
        public int CajaCantidadDoslps { get; set; }
        public int CajaCantidadCincolps { get; set; }
        public int CajaCantidadDiezlps { get; set; }
        public int CajaCantidadVeintelps { get; set; }
        public int CajaCantidadCincuentalps { get; set; }
        public int CajaCantidadCienlps { get; set; }
        public int CajaCantidadDoscientoslps { get; set; }
        public int CajaCantidadQuinientos { get; set; }
        public int CajaCantidadCincocent { get; set; }
        public int CajaCantidadDiezcent { get; set; }
        public int CajaCantidadVeintecent { get; set; }
        public int CajaCantidadCincuentacent { get; set; }
    }
}
