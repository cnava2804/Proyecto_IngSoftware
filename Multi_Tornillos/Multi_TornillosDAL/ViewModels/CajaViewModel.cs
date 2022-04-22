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
    }
}
