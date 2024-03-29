﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_TornillosDAL.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nombre Cajero")]
        public string Nombre { get; set; }
        [DisplayName("Identidad")]
        public string DNI { get; set; }
        [DisplayName("Contraseña")]
        public string Password { get; set; }
        [DisplayName("Tipo de Usuario")]
        public string Tipo { get; set; }
    }
}
