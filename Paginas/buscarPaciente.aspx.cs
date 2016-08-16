using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class buscarPaciente : System.Web.UI.Page
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
                dt = Biblioteca.fx.obtenerPaciente(txtRut.Text);
                DataView dv = new DataView();
                dv.Table = dt;

                if (dt.Rows.Count == 0)
                {
                    lblMessage.Text = "No existe un Paciente con rut: " + txtRut.Text;
                }
                else
                {
                    lblMessage.Text = "";
                    gvLista.DataSource = dv;
                    gvLista.DataBind();
                }



            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        
        protected void gvLista_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            //try
            //{

            //    int rut = int.Parse(gvLista.DataKeys[e.RowIndex].Value.ToString());
            //    Biblioteca.fx.eliminarPaciente(rut);
            //    gvLista.DataBind();
            //    lblMessage.Text = "Se ha eliminado el Paciente Correctamente";

            //}
            //catch (Exception ex)
            //{

            //    lblMessage.Text = ex.Message;
            //}

        }

      
        

    }
}