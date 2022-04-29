using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
   public class CierresViewModel
    {
        [DisplayName("Id")]
        public int Cierre_Id { get; set; }

        [DisplayName("Total Cierre")]
        public Nullable<decimal> CierreTotal { get; set; }

        [DisplayName("Tipo de cierre")]
        public string TipoCierre { get; set; }

        public int CajaId { get; set; }
        public int UsuarioId { get; set; }

        [DisplayName("Fecha Inicial")]
        public Nullable<System.DateTime> CierreFechaInicial { get; set; }

        [DisplayName("Fecha Final")]
        public Nullable<System.DateTime> CierreFechaFinal { get; set; }

        [DisplayName("Fecha del Cierre")]
        public Nullable<System.DateTime> CierreFecha { get; set; }

       

      
    }
}
