using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Paginas
{
    public partial class admUser : System.Web.UI.Page
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
                recargar();
            }


            
        }

        protected void recargar()
        {
            ddlCargo.DataSource = Biblioteca.fx.obtenerCargos();
            ddlCargo.DataBind();
            ddlCargo.Items.Insert(0, new ListItem("(Seleccione)", ""));

            ddlSede.DataSource = Biblioteca.fx.obtenerCentros();
            ddlSede.DataBind();
            ddlSede.Items.Insert(0, new ListItem("(Seleccione)", ""));

            

        }

        protected void generarVentana(string mensaje)
        {
            string script = @"<script type='text/javascript'>alert('"+ mensaje +"');</script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
           
	

            try
            {
                DataTable tUsuario = new DataTable();
                DataTable dt = new DataTable();
                dt = Biblioteca.fx.obtenerExisteFuncionario(txtRut.Text,txtCorreo.Text,txtFono.Text);
                //DataView dv = new DataView();
               // dv.Table = dt;
                 DataRow ds = dt.Rows[0];
                 string rutFun = ds["rut_fun"].ToString();
                 string emailFun = ds["email"].ToString();
                 string fonoFun = ds["fono_funcionario"].ToString();
                 //string emailFun = Biblioteca.fx.obtenerExisteEmail(txtCorreo.Text);

                string user = Biblioteca.fx.obtenerExisteUsuario(txtLogginNombre.Text);
                if (txtLogginNombre.Text == user)
                {
                    generarVentana("el usuario ya existe");

                }
                else if (txtCorreo.Text == emailFun)
                {
                    generarVentana("El mail escrito ya existe");
                }
                else if (txtFono.Text == fonoFun)
                {
                    generarVentana("El fono ya existe");
                }else

                if (rutFun != txtRut.Text)
                {
                    Biblioteca.Funcionario f = new Biblioteca.Funcionario();
                    f.Rut = int.Parse(txtRut.Text);
                    f.Dv = Biblioteca.fx.obtenerDv(txtRut.Text);
                    f.Nombre = txtNombre.Text;
                    f.Paterno = txtPaterno.Text;
                    f.Materno = txtMaterno.Text;
                    f.IdCentro = int.Parse(ddlSede.SelectedValue);
                    f.IdCargo = int.Parse(ddlCargo.SelectedValue);
                    f.Fono = int.Parse(txtFono.Text);
                    f.Email = txtCorreo.Text;
                    f.Direccion = txtDireccion.Text;
                   
                    Biblioteca.fx.agregarFuncionario(f);

                    Biblioteca.Usuario u = new Biblioteca.Usuario();

                    u.User = txtLogginNombre.Text;
                    u.Pass = txtLogginPass.Text;
                    u.RutFuncionario = int.Parse(txtRut.Text);
                    Biblioteca.fx.agregarUsuario(u);

                    generarVentana("Funcionario ingresado exitosamente");
                    Limpiar();

                }
                else {

                    generarVentana("El funcionario ya existe");
                
                }
                
                
                   
                
                
                
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        public void Limpiar() {

            txtRut.Text = string.Empty;
            txtDv.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPaterno.Text = string.Empty;
            txtMaterno.Text = string.Empty;
            ddlSede.SelectedIndex = 0;
            ddlCargo.SelectedIndex = 0;
            txtFono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtLogginNombre.Text = string.Empty;
            txtLogginPass.Text = string.Empty;
        
        
        
        }

        protected void txtLogginNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txtRut_TextChanged(object sender, EventArgs e)
        {
            txtDv.Text = Biblioteca.fx.obtenerDv(txtRut.Text); 
        }



       


    }
}