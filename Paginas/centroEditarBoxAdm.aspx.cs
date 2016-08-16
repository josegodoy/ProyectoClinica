using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class centroEditarBoxAdm : System.Web.UI.Page
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
            ddlTamano.DataSource = Biblioteca.fx.obtenerTamBox();
            ddlTamano.DataBind();

            ddlTipo.DataSource = Biblioteca.fx.obtenerTipoBox();
            ddlTipo.DataBind();



            ddlEstado.DataSource = Biblioteca.fx.obtenerEstadoBox();
            ddlEstado.DataBind();

            try
            {
                if (!string.IsNullOrEmpty((string)Request.QueryString["id"]))
                {
                    DataTable dt = Biblioteca.fx.obtenerBoxId(Request.QueryString["id"]);
                    DataRow ds = dt.Rows[0];
                    lblIdBox.Text = ds["id_box"].ToString();
                    ddlEstado.SelectedValue = ds["estado_id_estado"].ToString();
                    ddlTipo.SelectedValue = ds["tipo_id_tipo"].ToString();
                    ddlTamano.SelectedValue = ds["tamano_id_tamano"].ToString();

                }
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Biblioteca.Box b = new Biblioteca.Box();
                b.IdBox = int.Parse(lblIdBox.Text);
                b.IdTamano = int.Parse(ddlTamano.SelectedValue);
                b.IdTipo = int.Parse(ddlTipo.SelectedValue);
                b.IdEstado = int.Parse(ddlEstado.SelectedValue);
                Biblioteca.fx.editarBox(b);

                string script = @"<script type='text/javascript'>alert('Box Modificado exitosamente');</script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }



        }
    }
}