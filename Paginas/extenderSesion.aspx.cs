using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paginas
{
    public partial class extenderSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                recargar();
            }
        }

        protected void recargar()
        {
            try
            {
                if (!string.IsNullOrEmpty((string)Request.QueryString["id"]))
                {
                    lblId.Text = Request.QueryString["id"];
                }
            }
            catch (Exception ex)
            {
                
                lblMessage.Text = ex.Message;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ext = DateTime.Parse(txtFecha.Text + " " + txtHoraExtension.Text);
                Biblioteca.fx.extenderSesion(lblId.Text, ext);
                
                string correo = Biblioteca.fx.obtenerEmailEnfermera(lblId.Text);
                string asunto = "Sesion extendida";
                string mensaje = "La sesión  numero " + lblId.Text + " ha sido extendida hasta el día " + txtFecha.Text + " a las " + txtHoraExtension.Text + "";
                Biblioteca.fx.enviarMail("josegodoy2142@gmail.com", mensaje, asunto);
                string script = @"<script type='text/javascript'>alert('Sesion extendida');</script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);

                Response.Redirect("buscarSesion.aspx");
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }
    }
}