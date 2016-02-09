using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace Tarea_8
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int Validar()
        {
            int retorno = 0;
            if(UsuarioTextBox.Text == "" || ContrasenaTextBox.Text == "")
            {
                HttpContext.Current.Response.Write("<SCRIPT>alert('Debe lleanr todo los campos')</SCRIPT>");
                retorno = 0;
            }
            else
            {
                retorno = 1;
            }
            return retorno;
        }
        protected void InicioButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
    
            
            usuario.Inicio(UsuarioTextBox.Text, ContrasenaTextBox.Text);
           if (UsuarioTextBox.Text == usuario.NombreUsuario  && ContrasenaTextBox.Text == usuario.Contrasena && Validar() == 1)
            {
                
                FormsAuthentication.RedirectFromLoginPage(UsuarioTextBox.Text, false);
                Response.Redirect("UsuariosWeb.aspx");
           }

           else

            {

                ErrorLabel.Text = "Usuario o clave incorrecto";
            }

        }

        protected void CancelarButton_Click(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = "";
            ContrasenaTextBox.Text = "";
        }
    }
}