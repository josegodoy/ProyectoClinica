using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class modificarPaciente : System.Web.UI.Page
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

        protected void btnModificar_Click(object sender, EventArgs e)
        {
             try
            {
                Biblioteca.Paciente p = new Biblioteca.Paciente();

                p.Rut = int.Parse(lblRut.Text);
                p.Dv = lblDv.Text;
                p.Nombre = txtNombre.Text;
                p.Apaterno = txtAPaterno.Text;
                p.Amaterno = txtAMaterno.Text;
                p.Direccion = txtDireccion.Text;
                p.FechaNac = DateTime.Parse(txtFechaNac.Text);
                p.Fono = int.Parse(txtFono.Text);
                p.Etapa = 1;

                Biblioteca.fx.editarPaciente(p);

                string script = @"<script type='text/javascript'>alert('Paciente Modificado exitosamente');</script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);

            }
            catch (Exception ex)
            {

                lblRut.Text = ex.Message;
            }
        }
        protected void recargar()
        {
            try
            {
                if (!string.IsNullOrEmpty((string)Request.QueryString["id"]))
                {
                    DataTable dt = Biblioteca.fx.obtenerPaciente(Request.QueryString["id"]);
                    DataRow ds = dt.Rows[0];
                    lblRut.Text = ds["RUT_PACIENTE"].ToString();
                    lblDv.Text = ds["DV_RUT_PACIENTE"].ToString();
                    txtNombre.Text = ds["NOMBRE_PACIENTE"].ToString();
                    txtAPaterno.Text = ds["APATERNO_PACIENTE"].ToString();
                    txtAMaterno.Text = ds["AMATERNO_PACIENTE"].ToString();
                    txtDireccion.Text = ds["DIRECCION_PACIENTE"].ToString();
                    txtFechaNac.Text = ds["FECHA_NACIMIENTO"].ToString();
                    txtFono.Text = ds["FONO_PACIENTE"].ToString();


                }
            }
            catch(Exception ex)
            {
                throw;
            }

        }
    }
}