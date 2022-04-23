using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
    public class SaldosInicialesViewModel
    {
        public int SaldoInicial_Id { get; set; }
        [DisplayName("Total")]
        public decimal SaldoInicialTotal { get; set; }
        [DisplayName("Fecha")]
        public DateTime SaldoInicialFecha { get; set; }

        [Browsable(false)]
        public Nullable<int> UsuarioId { get; set; }

        [Browsable(false)]
        public Nullable<int> CajaId { get; set; }

        [Browsable(false)]
        public virtual Usuario Usuario { get; set; }

        [Browsable(false)]
        public virtual Caja Caja { get; set; }



    }
}
