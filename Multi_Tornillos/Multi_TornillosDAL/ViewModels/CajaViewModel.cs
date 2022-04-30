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
        [DisplayName("Cantidad 1L")]
        public int CajaCantidadUnlps { get; set; }
        [DisplayName("Cantidad 2L")]
        public int CajaCantidadDoslps { get; set; }
        [DisplayName("Cantidad 5L")]
        public int CajaCantidadCincolps { get; set; }
        [DisplayName("Cantidad 10L")]
        public int CajaCantidadDiezlps { get; set; }
        [DisplayName("Cantidad 20L")]
        public int CajaCantidadVeintelps { get; set; }
        [DisplayName("Cantidad 50L")]
        public int CajaCantidadCincuentalps { get; set; }
        [DisplayName("Cantidad 100L")]
        public int CajaCantidadCienlps { get; set; }
        [DisplayName("Cantidad 200L")]
        public int CajaCantidadDoscientoslps { get; set; }
        [DisplayName("Cantidad 500L")]
        public int CajaCantidadQuinientos { get; set; }
        [DisplayName("Cantidad 5cnt")]
        public int CajaCantidadCincocent { get; set; }
        [DisplayName("Cantidad 10cnt")]
        public int CajaCantidadDiezcent { get; set; }
        [DisplayName("Cantidad 20cnt")]
        public int CajaCantidadVeintecent { get; set; }
        [DisplayName("Cantidad 50cnt")]
        public int CajaCantidadCincuentacent { get; set; }
    }
}
