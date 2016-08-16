using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paginas
{
    public partial class admSesion : System.Web.UI.Page
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
            string id = Session["idCentro"].ToString();

            lblId.Text = Biblioteca.fx.obtenerIdSesion();
            if (lblId.Text == "")
            {
                lblId.Text = "1";
            }
            lblFechaAgendamiento.Text = DateTime.Now.ToShortDateString();

            ddlTratamiento.DataSource = Biblioteca.fx.obtenerTratamiento();
            ddlTratamiento.DataBind();
            ddlTratamiento.Items.Insert(0,new ListItem("(Seleccione)",""));

            ddlAuxiliar.DataSource = Biblioteca.fx.obtenerAuxiliares(id);
            ddlAuxiliar.DataBind();
            ddlAuxiliar.Items.Insert(0, new ListItem("(Seleccione)", ""));

            ddlEnfermera.DataSource = Biblioteca.fx.obtenerEnfermeras(id);
            ddlEnfermera.DataBind();
            ddlEnfermera.Items.Insert(0, new ListItem("(Seleccione)", ""));

           
        }

        protected void generarVentana(string mensaje)
        {
            string script = @"<script type='text/javascript'>alert('"+ mensaje + "');</script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);
        }

        protected void cambiarEstadoBotones(bool es)
        {
            btnAgregar.Enabled = es;
            txtExplicacion.Enabled = es;
            txtFechaInicio.Enabled = es;
            txthoraInicio.Enabled = es;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string rut = "";
            rut = Biblioteca.fx.buscarPacientePorRut(int.Parse(txtPaciente.Text));
            if (rut != txtPaciente.Text)
            {
                lblPaciente.Text = "El Paciente no existe, puede registarse <a href='agregarPaciente.aspx'>Aquí</a>";
                cambiarEstadoBotones(false);
            }
            else
            {
                cambiarEstadoBotones(true);
                lblPaciente.Text = "Paciente : " + Biblioteca.fx.obtenerNombrePaciente(int.Parse(txtPaciente.Text));
                txtPaciente.Enabled = false;
                btnBuscar.Enabled = false;
                
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (lblPaciente.Text == "")
                {
                    //lblMessage.Text = "La agenda debe tener un paciente inscrito";
                    generarVentana("La agenda debe tener un paciente inscrito");
                }
                else
                {
                

                Biblioteca.Agenda a = new Biblioteca.Agenda();
                //a.FechaInicio = DateTime.Parse(txtFechaInicio.Text);
               // DateTime hora = DateTime.Parse(txthoraInicio.Text);
                a.IdAtencion = int.Parse(lblId.Text);
                a.IdTratamiento = int.Parse(ddlTratamiento.SelectedValue);
                a.FechaInicio = DateTime.Parse(txtFechaInicio.Text + " " + txthoraInicio.Text);
                a.FechaAgendamiento = DateTime.Parse(lblFechaAgendamiento.Text);
                a.RutPaciente = int.Parse(txtPaciente.Text);
                a.Descripcion = txtExplicacion.Text;
                //a.FechaFin = DateTime.Parse(null);
                // a.TipoAtencion = "prueba";
          

                Biblioteca.fx.crearSesion(a);

                Biblioteca.fx.obtenerHoraFinal(a);

                Biblioteca.fx.agregarEquipoMedico(int.Parse(ddlAuxiliar.SelectedValue) , int.Parse(lblId.Text));
                Biblioteca.fx.agregarEquipoMedico(int.Parse(ddlFonoKine.SelectedValue), int.Parse(lblId.Text));
                Biblioteca.fx.agregarEquipoMedico(int.Parse(ddlEnfermera.SelectedValue), int.Parse(lblId.Text));
                Biblioteca.fx.agregarSesionPaciente(int.Parse(txtPaciente.Text));
                
                //Biblioteca.fx.editarEstadoFuncionarios(int.Parse(lblRut1.Text), int.Parse(lblRut2.Text), int.Parse(lblRut3.Text) 2);

               
                
                
                //string script = @"<script type='text/javascript'>alert('Sesión agendada exitosamente');</script>";
                //ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);

                string id = int.Parse(lblId.Text).ToString();
                //Response.Redirect("menuEnfermera.aspx");
                if (id.Length > 0)
                {
                    Response.Redirect("SalidaPDF.aspx?id=" + id);
                }

            }
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }



        }

        protected void ddlTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = Session["idCentro"].ToString();
            if (ddlTratamiento.SelectedValue == "1")
            {
                ddlFonoKine.DataSource = Biblioteca.fx.obtenerFonoaudiologos(id);
                lblEsp.Text = "Fonoaudiólogo";
            }
            else if (ddlTratamiento.SelectedValue == "2")
            {
                ddlFonoKine.DataSource = Biblioteca.fx.obtenerKinesiologos(id);
                lblEsp.Text = "Kinesiólogo";
            }
            else
            {
                ddlFonoKine.DataSource = Biblioteca.fx.obtenerMedicos();
                lblEsp.Text = "Médicos";
            }

            ddlFonoKine.DataBind();
        }

    }
}