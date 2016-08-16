using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class loginPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            DataTable dt = Biblioteca.fx.obtenerPacientes();
            DataRow ds = dt.Rows[0];
            int contador = dt.Rows.Count;
            

            for (int i = 0; i < contador; i++)
            {
                string rut = dt.Rows[i]["rut_paciente"].ToString();
                if (txtRut.Text == rut)
                {
                    Response.Redirect("pacienteConsulta.aspx");
                }
                else
                {
                    lblMessage.Text = "Usted no es un paciente inscrito";
                }
            }
        }
    }
}