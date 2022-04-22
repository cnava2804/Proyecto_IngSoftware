using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
   public  class SemanaViewModel
    {
        [DisplayName("Id")]
        public int SemanaId { get; set; }

        [DisplayName("Semana")]
        public string SemanaNombre { get; set; }

    }
}
