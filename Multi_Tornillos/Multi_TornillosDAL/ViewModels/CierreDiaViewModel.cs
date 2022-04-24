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
