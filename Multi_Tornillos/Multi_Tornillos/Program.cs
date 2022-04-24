
using Multi_Tornillos.Views;
using Multi_Tornillos.Views.Caja;
using Multi_Tornillos.Views.SaldosIniciales;
using Multi_Tornillos.Views.Usuario;
using Multi_Tornillos.Views.CierreDia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tornillos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCierreDiaList()); ;
        }
    }
}
