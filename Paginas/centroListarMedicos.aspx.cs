using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class centroListarMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOG"] == null)
            {
                Response.Redirect("inicio.aspx");
            }
        }

        public void cargarLista()
        {



            try
            {
                DataTable dt = new DataTable();
                dt = Biblioteca.fx.obtenerEquipoMedico(txtFecha.Text);
                DataView dv = new DataView();
                dv.Table = dt;
                if (dt.Rows.Count == 0)
                {
                    string script = @"<script type='text/javascript'>alert('No se registraron Equipos medicos para esa Fecha');</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);
                }
                else
                {
                    gdvListar.DataSource = dv;
                    gdvListar.DataBind();
                   
                }

            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }


        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            cargarLista();
        }
    }
}