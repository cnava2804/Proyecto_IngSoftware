using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
    public class BitacoraViewModel
    {
        [DisplayName("Id")]
        public int Bitacora_Id { get; set; }

        [DisplayName("Descripción")]
        public string BitacoraDescripcion { get; set; }

        [DisplayName("Fecha de Creacion")]
        public DateTime BitacoraFecha { get; set; }

        
    }
}
