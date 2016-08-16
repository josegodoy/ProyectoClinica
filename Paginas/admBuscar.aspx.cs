using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class admBuscar1 : System.Web.UI.Page
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
                DataTable dt = new DataTable();
                dt = Biblioteca.fx.obtenerFuncionario(txtRutBuscar.Text);
                DataView dv = new DataView();
                dv.Table = dt;

                if (dt.Rows.Count == 0)
                {
                    lblMen.Text = "No existe un Funcionario con rut: " + txtRutBuscar.Text;
                }
                else
                {
                    lblMen.Text = "";
                    gdvLista.DataSource = dv;
                    gdvLista.DataBind();
                }

                

            }
            catch (Exception ex )
            {

                lblMen.Text = ex.Message;
            }
        }

        protected void gdvLista_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                int rut = int.Parse(gdvLista.DataKeys[e.RowIndex].Value.ToString());
                Biblioteca.fx.eliminarFuncionario(rut);
                gdvLista.DataBind();
                lblMen.Text = "Se ha eliminado el Funcionario Correctamente";

            }
            catch (Exception ex)
            {

                lblMen.Text = ex.Message;
            }
        }

        

    }
}