using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class centroEditarBox : System.Web.UI.Page
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

            //ddlIdBox.DataSource = Biblioteca.fx.obtenerBox();
            //ddlIdBox.DataBind();
            ////ddlIdBox.Items.Insert(0, new ListItem("(Seleccione)",""));

            //ddlTipoBox.DataSource = Biblioteca.fx.obtenerTipoBox();
            //ddlTipoBox.DataBind();
            ////ddlTipoBox.Items.Insert(0, new ListItem("(Seleccione)", ""));


            //ddlEstadoBox.DataSource = Biblioteca.fx.obtenerEstadoBox();
            //ddlEstadoBox.DataBind();
            //ddlEstadoBox.Items.Insert(0, new ListItem("(Seleccione)", ""));





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

        //protected void btnModificar_Click(object sender, EventArgs e)
        //{
        //    Biblioteca.Box b = new Biblioteca.Box();
        //    b.IdBox = int.Parse(ddlIdBox.SelectedValue);
        //    b.IdCentro = 2;
        //    b.IdTipo = int.Parse(ddlTipoBox.SelectedValue);
        //    b.IdEstado = int.Parse(ddlEstadoBox.SelectedValue);
        //    Biblioteca.fx.editarBox(b);

        //    string script = @"<script type='text/javascript'>alert('Box Modificado exitosamente');</script>";
        //    ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);
        //    recargar();
        //}
    }
}