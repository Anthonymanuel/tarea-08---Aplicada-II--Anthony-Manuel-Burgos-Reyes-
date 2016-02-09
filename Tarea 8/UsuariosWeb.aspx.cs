using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Tarea_8
{
    public partial class UsuariosWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LlenarDatos(Usuarios usuario)
        {
            
            usuario.NombreUsuario = NombreUsuarioTextBox.Text;
            if (ContrasenaTextBox.Text == ConfirmarContrasenaTextBox.Text)
            {
                usuario.Contrasena = ContrasenaTextBox.Text;
            }
        }

        public void Limpiar()
        {
            NombreUsuarioTextBox.Text = "";
            ContrasenaTextBox.Text = "";
            ConfirmarContrasenaTextBox.Text = "";

        }

        protected void RegistrarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            LlenarDatos(usuario);

            if (usuario.Insertar() )
            {
                Limpiar();
                HttpContext.Current.Response.Write("<SCRIPT>alert('Usuario Guardado')</SCRIPT>");
            }
            else
            {
                HttpContext.Current.Response.Write("<SCRIPT>alert('Error al guardar el usuario')</SCRIPT>");
            }
        }

        protected void CancelarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}