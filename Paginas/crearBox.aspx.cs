using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class crearBox : System.Web.UI.Page
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
            

                    lblIdBox.Text = Biblioteca.fx.obtenerIdBox();
                    if (lblIdBox.Text == "")
                    {
                        lblIdBox.Text = "1";
                    }

                    ddlTipoBox.DataSource = Biblioteca.fx.obtenerTipoBox();
                    ddlTipoBox.DataBind();
                    //ddlTipoBox.Items.Insert(0, new ListItem("(Seleccione)", ""));

                    ddlTamanoBox.DataSource = Biblioteca.fx.obtenerTamBox();
                    ddlTamanoBox.DataBind();
                   //ddlTamanoBox.Items.Insert(0, new ListItem("(Seleccione)",""));

                    


        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            string id = Session["idCentro"].ToString();
            string fila;
            fila = Biblioteca.fx.cantidadBox(id);
            int filas = int.Parse(fila);
            try
            {
                if (filas < 12)
                {


                    Biblioteca.Box b = new Biblioteca.Box();
                   //b.IdBox = int.Parse(lblIdBox.Text);
                    //b.IdBox = int.Parse(id);
                    b.IdCentro = int.Parse(id);
                    b.IdTipo = int.Parse(ddlTipoBox.SelectedValue);
                    b.IdTamano = int.Parse(ddlTamanoBox.SelectedValue);
                    
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

            ddlTipoBox.SelectedIndex = 0;
            ddlTamanoBox.SelectedIndex = 0;
           
        }

    }
}