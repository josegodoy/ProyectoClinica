using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class buscarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOG"] == null)
            {
                Response.Redirect("inicio.aspx");
            }
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
            cargarLista();
        }

        protected void cargarLista()
        {
            try
            {
                string idC = Session["idCentro"].ToString();
                DataTable dt = new DataTable();
                int tra = 0;
                DataView dv = new DataView();
                if (cboKine.Checked) tra = 2;
                if (cboFono.Checked) tra = 1;
                dt = Biblioteca.fx.obtenerSesiones(txtFechaInicio.Text, txtFechaFin.Text, tra,idC);
                dv.Table = dt;
                gdvLista.DataSource = dv;
                gdvLista.DataBind();

                if (gdvLista.Rows.Count == 0)
                {
                    lblMessage.Text = "No se han encontrado resultados";
                }
                else
                {
                    lblMessage.Text = "";
                }
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

      

       

        protected void gdvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           
            if (e.CommandName=="Finalizar")
            {
                try
                {
                    GridViewRow row = (GridViewRow)(e.CommandSource as LinkButton).Parent.Parent;
                    string id = row.Cells[0].Text;
                    
                    //lblMessage.Text = id.ToString();
                    string rutPaciente = Biblioteca.fx.obtenerRutPacienteSesion(id);
                    Biblioteca.fx.agregarSesionFinPaciente(int.Parse(rutPaciente));
                    string correo = Biblioteca.fx.obtenerEmailEnfermera(id.ToString());
                    string asunto = "Sesion finalizada";
                    string mensaje = "La sesión número " + id + " ha finalizado";
                    Biblioteca.fx.enviarMail("josegodoy2142@gmail.com", asunto, mensaje); //puse mi mail personal para hacer la prueba. Debería usar el mail de la enfermera (Que no existe realmente).
                    Biblioteca.fx.finalizarSesion(id.ToString());
                    string script = @"<script type='text/javascript'>alert('La sesión ha sido finalizada');</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false); 
                }
                catch (Exception ex)
                {
                    
                    lblMessage.Text = ex.Message;
                }

            }



            
        }

        protected void gdvLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        


       
    }
}