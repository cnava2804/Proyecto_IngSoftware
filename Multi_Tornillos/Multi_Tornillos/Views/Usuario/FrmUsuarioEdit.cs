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
    public partial class FrmUsuarioEdit : Form
    {
        private Multi_TornillosDAL.Usuario usuario;
        private readonly UsuarioController controller;
        public FrmUsuarioEdit(Multi_TornillosDAL.Usuario usuario)
        {
            InitializeComponent();
            controller = new UsuarioController();
            this.usuario = usuario;

            txtId.Text = usuario.UsuarioId.ToString();
            txtNombre.Text = usuario.UsuarioNombre;
            txtPassword.Text = usuario.UsuarioPassword;
            txtRTN.Text = usuario.UsuarioDNI;
            if (usuario.UsuarioTipo == "Usuario")
            {
                rbUsuario.Checked = true;
            }
            else 
            {
                rbAdministrador.Checked = true;
            }
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
                    UsuarioId = Convert.ToInt32(txtId.Text),
                    UsuarioNombre = txtNombre.Text,
                    UsuarioPassword = Encrypt.GetSHA256(txtPassword.Text),
                    UsuarioDNI = txtRTN.Text,
                    UsuarioTipo = tipo
                };

                if (controller.Edit(usuario))
                {
                    MessageBox.Show("Usuario editado correctamente");
                    controller.Dispose();
                    this.Dispose();
                }
                else 
                {
                    MessageBox.Show("No se ha podido editar el usuario");
                }
                this.Close();
            }
            else 
            {
                MessageBox.Show("Las constraseñas no coinciden");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
