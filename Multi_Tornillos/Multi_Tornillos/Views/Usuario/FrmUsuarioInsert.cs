using Multi_TornillosBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tornillos.Views.Usuario
{
    public partial class FrmUsuarioInsert : Form
    {
        private readonly UsuarioController controller;
        public FrmUsuarioInsert()
        {
            InitializeComponent();
            controller = new UsuarioController();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var tipo = "";
            if (rbUsuario.Checked == false && rbAdministrador.Checked == false)
            {
                MessageBox.Show("Seleccione el tipo de usuario");
            }
            else if (rbUsuario.Checked)
            {
                tipo = "Usuario";
            }
            else if (rbAdministrador.Checked)
            {
                tipo = "Administrador";
            }

            if (txtPassword.Text == txtConfirmar.Text)
            {
                Multi_TornillosDAL.Usuario usuario = new Multi_TornillosDAL.Usuario
                {
                    UsuarioNombre = txtNombre.Text,
                    UsuarioPassword = txtPassword.Text,
                    UsuarioRTN = txtRTN.Text,
                    UsuarioTipo = tipo
                };

                if (controller.Add(usuario))
                {
                    MessageBox.Show("Usuario ingresado correctamente");
                    controller.Dispose();
                    this.Dispose();
                }
                else 
                {
                    MessageBox.Show("No se ha podido ingresar el usuario");
                }
                this.Close();
            }
            else 
            {
                MessageBox.Show("Las constraseñas no coinciden");
            }
        }
    }
}
