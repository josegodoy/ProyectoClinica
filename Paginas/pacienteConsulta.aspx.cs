using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class pacienteConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                recargar();
                ddlMedicos.Enabled = false;
                btnMedicos.Enabled = false;

                ddlKine.Enabled = false;
                btnKine.Enabled = false;

                dllFono.Enabled = false;
                btnFono.Enabled = false;
            }
        }

        protected void recargar()
        {
            ddlCentro.DataSource = Biblioteca.fx.obtenerCentros();
            ddlCentro.DataBind();
            ddlCentro.Items.Insert(0, new ListItem("(Seleccione)", ""));

            ddlKine.Items.Insert(0, new ListItem("(Seleccione)", ""));
            dllFono.Items.Insert(0, new ListItem("(Seleccione)", ""));
            ddlMedicos.Items.Insert(0, new ListItem("(Seleccione)", ""));
        }

        protected void btnMedicos_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ddlMedicos.SelectedIndex == 0)
                {
                    lblPrueba.Text = "Seleccione un Médico";
                }
                else
                {

                    dt = Biblioteca.fx.obtenerInfoProfesional(ddlMedicos.SelectedValue);
                    DataView dv = new DataView();
                    dv.Table = dt;
                    gdvListaMedicos.DataSource = dv;
                    gdvListaMedicos.DataBind();


                }
            }
            catch (Exception ex)
            {

                lblPrueba.Text = ex.Message;
            }
        }

        protected void btnKine_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ddlKine.SelectedIndex == 0)
                {
                    lblPrueba.Text = "Seleccione un Kinesiólogo";
                }
                else
                {

                    dt = Biblioteca.fx.obtenerInfoProfesional(ddlKine.SelectedValue);
                    DataView dv = new DataView();
                    dv.Table = dt;
                    gdvListaMedicos.DataSource = dv;
                    gdvListaMedicos.DataBind();


                }
            }
            catch (Exception ex)
            {

                lblPrueba.Text = ex.Message;
            }
        }

        protected void btnFono_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (dllFono.SelectedIndex == 0)
                {
                    lblPrueba.Text = "Seleccione un Fonoaudiólogo";
                }
                else
                {

                    dt = Biblioteca.fx.obtenerInfoProfesional(dllFono.SelectedValue);
                    DataView dv = new DataView();
                    dv.Table = dt;
                    gdvListaMedicos.DataSource = dv;
                    gdvListaMedicos.DataBind();


                }
            }
            catch (Exception ex)
            {

                lblPrueba.Text = ex.Message;
            }
        }

        protected void cargarLista()
        {
            ddlMedicos.DataSource = Biblioteca.fx.obtenerMedicosCentro(int.Parse(ddlCentro.SelectedValue));
            ddlMedicos.DataBind();
            ddlMedicos.Items.Insert(0, new ListItem("(Seleccione)", ""));

            ddlKine.DataSource = Biblioteca.fx.obtenerKineCentro(int.Parse(ddlCentro.SelectedValue));
            ddlKine.DataBind();
            ddlKine.Items.Insert(0, new ListItem("(Seleccione)", ""));


            dllFono.DataSource = Biblioteca.fx.obtenerFonoCentro(int.Parse(ddlCentro.SelectedValue));
            dllFono.DataBind();
            dllFono.Items.Insert(0, new ListItem("(Seleccione)", ""));

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void ddlCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

             
                    ddlMedicos.Enabled = true;
                    btnMedicos.Enabled = true;

                    ddlKine.Enabled = true;
                    btnKine.Enabled = true;

                    dllFono.Enabled = true;
                    btnFono.Enabled = true;
                    cargarLista();

                

            }
            catch (Exception ex)
            {

                lblPrueba.Text = ex.Message;
            }
        }
    }
}