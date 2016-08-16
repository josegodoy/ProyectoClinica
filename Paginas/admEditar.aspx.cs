using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class admEditar : System.Web.UI.Page
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
                Biblioteca.Funcionario f = new Biblioteca.Funcionario();

                f.Rut = int.Parse(lblRut.Text);
                //f.Dv = lblDv.Text;
                f.Nombre = txtNombreEdit.Text;
                f.Paterno = txtPaternoEdit.Text;
                f.Materno = txtMaternoEdit.Text;
                f.Direccion = txtDireccionEdit.Text;
                f.Email = txtCorreoEdit.Text;
                f.Fono = int.Parse(txtFonoEdit.Text);
                f.IdCargo = int.Parse(ddlCargo.SelectedValue);
                f.IdCentro = int.Parse(ddlCentro.SelectedValue);
                f.Estado = int.Parse(ddlEstado.SelectedValue);

                Biblioteca.fx.editarFuncionario(f);

                string script = @"<script type='text/javascript'>alert('Funcionario Modificado exitosamente');</script>";
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
                    DataTable dt = Biblioteca.fx.obtenerFuncionario(Request.QueryString["id"]);
                    DataRow ds = dt.Rows[0];
                    lblRut.Text = ds["RUT_FUN"].ToString();
                    lblDv.Text = ds["DV_RUT_FUN"].ToString();
                    txtNombreEdit.Text = ds["NOMBRE_FUN"].ToString();
                    txtPaternoEdit.Text = ds["APATERNO_FUN"].ToString();
                    txtMaternoEdit.Text = ds["AMATERNO_FUN"].ToString();
                    txtDireccionEdit.Text = ds["DIRECCION_FUNCIONARIO"].ToString();
                    txtCorreoEdit.Text = ds["EMAIL"].ToString();
                    txtFonoEdit.Text = ds["FONO_FUNCIONARIO"].ToString();

                    ddlCargo.DataSource = Biblioteca.fx.obtenerCargos();
                    ddlCargo.DataBind();

                    ddlCentro.DataSource = Biblioteca.fx.obtenerCentros();
                    ddlCentro.DataBind();

                    ddlEstado.DataSource = Biblioteca.fx.obtenerEstadoFun();
                    ddlEstado.DataBind();
                    ///ddlEstado.Items.Insert(0, new ListItem("(Seleccione)", ""));

                    ddlCargo.SelectedValue = ds["NOMBRE_CARGO"].ToString();
                    ddlCentro.SelectedValue = ds["NOMBRE_CENTRO"].ToString();
                    ddlEstado.SelectedValue = ds["NOMBRE_ESTADO"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}