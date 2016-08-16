using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class centroAgregarBox : System.Web.UI.Page
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


            lblIDbox.Text = Biblioteca.fx.obtenerIdBox();
            if (lblIDbox.Text == "")
            {
                lblIDbox.Text = "1";
            }

            ddlTipoBoxAdd.DataSource = Biblioteca.fx.obtenerTipoBox();
            ddlTipoBoxAdd.DataBind();
            //ddlTipoBox.Items.Insert(0, new ListItem("(Seleccione)", ""));

            dllTamañoAdd.DataSource = Biblioteca.fx.obtenerTamBox();
            dllTamañoAdd.DataBind();
            //ddlTamanoBox.Items.Insert(0, new ListItem("(Seleccione)",""));




        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = Session["idCentro"].ToString();
            string fila;
            fila = Biblioteca.fx.cantidadBox(id);
            int filas = int.Parse(fila);
            

            try
            {
                if (filas < 12)
                {


                    Biblioteca.Box b = new Biblioteca.Box();
                    // b.IdBox = int.Parse(lblIdBox.Text);
                    b.IdBox = int.Parse(id);
                    b.IdCentro = 2;
                    b.IdTipo = int.Parse(ddlTipoBoxAdd.SelectedValue);
                    b.IdTamano = int.Parse(ddlTipoBoxAdd.SelectedValue);

                    Biblioteca.fx.agregarBox(b);

                    string script = @"<script type='text/javascript'>alert('Box creado exitosamente');</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);
                    Limpiar();
                    recargar();
                }
                else
                {
                    string script = @"<script type='text/javascript'>alert('Ha alcanzado el numero maximo de Box');</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);


                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        public void Limpiar()
        {

            ddlTipoBoxAdd.SelectedIndex = 0;
            dllTamañoAdd.SelectedIndex = 0;

        }
    }
}