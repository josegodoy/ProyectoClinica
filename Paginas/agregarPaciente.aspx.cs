using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class agregarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOG"] == null)
            {
                Response.Redirect("inicio.aspx");
            }
            if (!IsPostBack)
            {
                txtDv.Text = Biblioteca.fx.obtenerDv(txtRut.Text);  
            }
        }



        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable tUsuario = new DataTable();
                string rutPac = Biblioteca.fx.obtenerExistePac(txtRut.Text);

                if (rutPac != txtRut.Text)
                {
                    Biblioteca.Paciente p = new Biblioteca.Paciente();
                    p.Rut = int.Parse(txtRut.Text);
                    p.Dv = Biblioteca.fx.obtenerDv(txtRut.Text);
                    p.Nombre = txtNombre.Text;
                    p.Apaterno = txtAPaterno.Text;
                    p.Amaterno = txtAMaterno.Text;
                    p.FechaNac = DateTime.Parse(txtFechaNac.Text);
                    p.Direccion = txtDireccion.Text;
                    p.Fono = int.Parse(txtFono.Text);
                    
                    p.Etapa = 1;
                    Biblioteca.fx.agregarPaciente(p);
                    
                    string edad = Biblioteca.fx.obtenerEdadPaciente(int.Parse(txtRut.Text));
                    int edadP = int.Parse(edad);
                    if (edadP >= 0 && edadP <=4)
                    {
                       p.Etapa = 1;
                    }
                    else if (edadP >= 5 && edadP <= 14)
                    {
                        p.Etapa = 2;
                    }
                    else
                    {
                        p.Etapa = 3;
                    }

                    Biblioteca.fx.cambiarEtapaPaciente(int.Parse(txtRut.Text) , p.Etapa);
                   

                    

                    string script = @"<script type='text/javascript'>alert('Paciente ingresado exitosamente');</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);
                    Limpiar();




                }
                else
                {

                    string script = @"<script type='text/javascript'>alert('El Paciente ya Existe');</script>";
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

            txtRut.Text = string.Empty;
            txtDv.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtAPaterno.Text = string.Empty;
            txtAMaterno.Text = string.Empty;
            txtFono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            



        }

        protected void txtRut_TextChanged(object sender, EventArgs e)
        {
            txtDv.Text = Biblioteca.fx.obtenerDv(txtRut.Text);  
        }


    }
}