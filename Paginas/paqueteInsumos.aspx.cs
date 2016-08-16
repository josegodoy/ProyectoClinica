using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class paqueteInsumos : System.Web.UI.Page
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
            cargarLista();
        }

        protected void cargarLista()
        {
            try
            {
                DataTable dt = new DataTable();
                //int tra = 0;
                DataView dv = new DataView();
                string id = Session["idTratamiento"].ToString();
                dt = Biblioteca.fx.obtenerInsumosPaquete(id);
                dv.Table = dt;
                gdvLista.DataSource = dv;
                gdvLista.DataBind();
            }
            catch (Exception ex)
            {

                //lblMessage.Text = ex.Message;
            }
        }
    }
}