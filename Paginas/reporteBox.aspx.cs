using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class reporteBox : System.Web.UI.Page
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
            string centro = Session["idCentro"].ToString();
            ddlBox.DataSource = Biblioteca.fx.obtenerBoxCentro(centro);
            ddlBox.DataBind();
           
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarLista();
        }

        protected void cargarLista()
        {
            try
            {
                DataTable dt = new DataTable();
                DataView dv = new DataView();

                dt = Biblioteca.fx.reporteBox(ddlBox.SelectedValue);
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
    }
}