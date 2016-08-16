using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class insumos : System.Web.UI.Page
    {
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["LOG"] == null)
            //{
            //    Response.Redirect("index.aspx");
            //}

            if (!IsPostBack)
            {
                recargar();
            }
        }

        protected void recargar()
        {
            lblAgenda.Text = Session["idsesion"].ToString();
            dt = Biblioteca.fx.obtenerInsumosAdicionales();
            cargarLista();               
            
        }

        protected void cargarLista()
        {
            DataView dv = new DataView();
            dv.Table = dt;
            gdvLista.DataSource = dv;
            gdvLista.DataBind();
        }

        protected void btnInsumos_Click(object sender, EventArgs e)
        {
            try
            {
                //string data = "";
               
                foreach (GridViewRow row in gdvLista.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        TextBox txtRow = (row.Cells[0].FindControl("txtCant") as TextBox);
                        if (txtRow.Text != "")
                        {
                            string id = row.Cells[0].Text; //obtener el id de la fila recorrida
                            string nombre = row.Cells[1].Text; //darle el valor del nombre a la variable
                            string cantidad = row.Cells[2].Text; //darle el valor de la cantidad a la variable
                            Biblioteca.fx.insertarCantidadConsumida(int.Parse(txtRow.Text), int.Parse(id), int.Parse(lblAgenda.Text));
                            Biblioteca.fx.restarInsumos(nombre, int.Parse(txtRow.Text));


                        }
                    }
                }

                
                Page.RegisterStartupScript("script", "<script> window.close() </script>");
                //lblMsg.Text = data;
               
            }
            catch (Exception ex)
            {

                lblMsg.Text = ex.Message;
            }
        }
    }
}