using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class modificarBox : System.Web.UI.Page
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
            cargarLista();

           





        }

        protected void cargarLista()
        {
            try
            {
                DataTable dt = new DataTable();
                string centro = Session["idCentro"].ToString();
                DataView dv = new DataView();
                dt = Biblioteca.fx.listarBox(centro);
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