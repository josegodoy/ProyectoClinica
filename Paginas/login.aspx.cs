using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Configuration;
using System.Data;

namespace Paginas
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNombreLogg.Text.Trim();
                string contra = TxtPassLogg.Text.Trim();
                string cargo;
                string nombre;
                string apellido;
                string centro;
                string idCentro;

                DataTable dt = Biblioteca.fx.obtenerUsuarios();
                DataRow ds = dt.Rows[0];

                int contador = dt.Rows.Count;

                for (int i = 0; i < contador; i++)
                {
                    name = dt.Rows[i]["USUARIO_SISTEMA"].ToString();
                    contra = dt.Rows[i]["CONTRASENA"].ToString();
                    cargo = dt.Rows[i]["CARGO_ID_CARGO"].ToString();
                    nombre = dt.Rows[i]["NOMBRE_FUN"].ToString();
                    apellido = dt.Rows[i]["APATERNO_FUN"].ToString();
                    idCentro = dt.Rows[i]["id_centro"].ToString();
                    centro = dt.Rows[i]["NOMBRE_CENTRO"].ToString();

                    Session["LOG"] = nombre + " " + apellido;
                    Session["centro"] = centro;
                    Session["idCentro"] = idCentro;

                    if (name == txtNombreLogg.Text && contra == TxtPassLogg.Text && cargo == "1")
                    {


                        Response.Redirect("admInstitucion.aspx");



                    }

                    else if (name == txtNombreLogg.Text && contra == TxtPassLogg.Text && cargo == "2")
                    {
                        Response.Redirect("admCentro.aspx");
                    }
                    else if (name == txtNombreLogg.Text && contra == TxtPassLogg.Text && cargo == "3")
                    {
                        Response.Redirect("enfermeraBox.aspx");

                    }
                    else
                    {
                        lblMsj.Text = "Nombre de usuario o contraseña Incorrecta";
                    }
                }

            }
            catch (Exception ex)
            {

                lblMsj.Text = ex.Message;
            }

        }
    }
}