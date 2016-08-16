using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class reporteInsumos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["LOG"] == null)
            {
                Response.Redirect("inicio.aspx");
            }

            if (!IsPostBack)
            {
                recargar();
            }

        }


        protected void recargar()
        {
            try
            {
                dllAgendas.DataSource = Biblioteca.fx.listarAgendas();
                dllAgendas.DataBind();
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
           
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarLista();

            if (gdvLista.Rows.Count < 1)
            {
                lblMessage.Text = "No se encontraron resultados";
            }
            else
            {
                lblMessage.Text = "";
            }
        }

        protected void cargarLista()
        {
            try
            {
                DataTable dt = new DataTable();
                DataView dv = new DataView();
                
                dt = Biblioteca.fx.reporteInsumos(dllAgendas.SelectedValue);
                dv.Table = dt;
                gdvLista.DataSource = dv;
                gdvLista.DataBind();
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }
    }
}