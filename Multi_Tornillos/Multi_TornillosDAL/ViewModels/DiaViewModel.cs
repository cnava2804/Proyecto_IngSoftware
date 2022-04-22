using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
    public class DiaViewModel
    {
        [DisplayName("Id")]
        public int DiaId { get; set; }

        [DisplayName("Num. Dia")]
        public string DiaNombre { get; set; }
    }
}
