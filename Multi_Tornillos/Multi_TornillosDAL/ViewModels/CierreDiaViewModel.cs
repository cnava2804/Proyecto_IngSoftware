using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
    public class CierreDiaViewModel
    {
        public int CierreDia_Id { get; set; }
        [DisplayName("Total Dia")]
        public decimal CierreDiaTotal { get; set; }
        [DisplayName("Fecha Cierre")]
        public DateTime CierreDiaFecha { get; set; }

        public int CierreDiaCantidadUnlps { get; set; }
        [DisplayName("Cantidad 2L")]
        public int CierreDiaCantidadDoslps { get; set; }
        [DisplayName("Cantidad 5L")]
        public int CierreDiaCantidadCincolps { get; set; }
        [DisplayName("Cantidad 10L")]
        public int CierreDiaCantidadDiezlps { get; set; }
        [DisplayName("Cantidad 20L")]
        public int CierreDiaCantidadVeintelps { get; set; }
        [DisplayName("Cantidad 50L")]
        public int CierreDiaCantidadCincuentalps { get; set; }
        [DisplayName("Cantidad 100L")]
        public int CierreDiaCantidadCienlps { get; set; }
        [DisplayName("Cantidad 200L")]
        public int CierreDiaCantidadDoscientoslps { get; set; }
        [DisplayName("Cantidad 500L")]
        public int CierreDiaCantidadQuinientos { get; set; }
        [DisplayName("Cantidad 5cnt")]
        public int CierreDiaCantidadCincocent { get; set; }
        [DisplayName("Cantidad 10cnt")]
        public int CierreDiaCantidadDiezcent { get; set; }
        [DisplayName("Cantidad 20cnt")]
        public int CierreDiaCantidadVeintecent { get; set; }
        [DisplayName("Cantidad 50cnt")]
        public int CierreDiaCantidadCincuentacent { get; set; }

        [Browsable(false)]
        public Nullable<int> SaldoInicial_Id { get; set; }



        [Browsable(false)]
        public Nullable<int> UsuarioId { get; set; }

        [Browsable(false)]
        public Nullable<int> CajaId { get; set; }
        [Browsable(false)]
        public virtual SaldosIniciales SaldosIniciales { get; set; }

        [Browsable(false)]
        public virtual Usuario Usuario { get; set; }

        [Browsable(false)]
        public virtual Caja Caja { get; set; }
    }
}
