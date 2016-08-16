using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class listaBox : System.Web.UI.Page
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
            DataTable dt = new DataTable();
            string id = Session["icCentro"].ToString();
            dt = Biblioteca.fx.listarBox(id);
            //DataRow ds = dt.Rows[0];
            //int rows = dt.Rows.Count;

            foreach (DataRow ds in dt.Rows)
            {
                //Box 1
                if (ds["id_box"].ToString() == "1" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox1.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "1" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox1.ImageUrl = "img/boxOcupado.png";
                    btnBox1.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "1" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox1.ImageUrl = "img/boxEnMantencion.png";
                    btnBox1.Enabled = false;
                }

                if (ds["id_box"].ToString() == "1")
                {
                    lblTipo1.Text = ds["nombre_tipo"].ToString();
                    lblTamano1.Text = ds["tamano"].ToString();
                    lblIdBox1.Text = ds["id_box"].ToString();
                }

                //Box 2
                if (ds["id_box"].ToString() == "2" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox2.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "2" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox2.ImageUrl = "img/boxOcupado.png";
                    btnBox2.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "2" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox2.ImageUrl = "img/boxEnMantencion.png";
                    btnBox2.Enabled = false;
                }

                if (ds["id_box"].ToString() == "2")
                {
                    lblTipo2.Text = ds["nombre_tipo"].ToString();
                    lblTamano2.Text = ds["tamano"].ToString();
                    lblIdBox2.Text = ds["id_box"].ToString();
                }

                //Box 3
                if (ds["id_box"].ToString() == "3" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox3.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "3" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox3.ImageUrl = "img/boxOcupado.png";
                    btnBox3.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "3" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox3.ImageUrl = "img/boxEnMantencion.png";
                    btnBox3.Enabled = false;
                }

                if (ds["id_box"].ToString() == "3")
                {
                    lblTipo3.Text = ds["nombre_tipo"].ToString();
                    lblTamano3.Text = ds["tamano"].ToString();
                    lblIdBox3.Text = ds["id_box"].ToString();
                }

                //Box 4
                if (ds["id_box"].ToString() == "4" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox4.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "4" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox4.ImageUrl = "img/boxOcupado.png";
                    btnBox4.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "4" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox4.ImageUrl = "img/boxEnMantencion.png";
                    btnBox4.Enabled = false;
                }

                if (ds["id_box"].ToString() == "4")
                {
                    lblTipo4.Text = ds["nombre_tipo"].ToString();
                    lblTamano4.Text = ds["tamano"].ToString();
                    lblIdBox4.Text = ds["id_box"].ToString();
                }

                //Box 5
                if (ds["id_box"].ToString() == "5" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox5.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "5" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox5.ImageUrl = "img/boxOcupado.png";
                    btnBox5.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "5" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox5.ImageUrl = "img/boxEnMantencion.png";
                    btnBox5.Enabled = false;
                }

                if (ds["id_box"].ToString() == "5")
                {
                    lblTipo5.Text = ds["nombre_tipo"].ToString();
                    lblTamano5.Text = ds["tamano"].ToString();
                    lblIdBox5.Text = ds["id_box"].ToString();
                }

                //Box 6
                if (ds["id_box"].ToString() == "6" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox6.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "6" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox6.ImageUrl = "img/boxOcupado.png";
                    btnBox6.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "6" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox6.ImageUrl = "img/boxEnMantencion.png";
                    btnBox6.Enabled = false;
                }

                if (ds["id_box"].ToString() == "6")
                {
                    lblTipo6.Text = ds["nombre_tipo"].ToString();
                    lblTamano6.Text = ds["tamano"].ToString();
                    lblIdBox6.Text = ds["id_box"].ToString();
                }

                //Box 7
                if (ds["id_box"].ToString() == "7" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox7.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "7" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox7.ImageUrl = "img/boxOcupado.png";
                    btnBox7.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "7" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox7.ImageUrl = "img/boxEnMantencion.png";
                    btnBox7.Enabled = false;
                }

                if (ds["id_box"].ToString() == "7")
                {
                    lblTipo7.Text = ds["nombre_tipo"].ToString();
                    lblTamano7.Text = ds["tamano"].ToString();
                    lblIdBox7.Text = ds["id_box"].ToString();
                }

                //Box 8
                if (ds["id_box"].ToString() == "8" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox8.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "8" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox8.ImageUrl = "img/boxOcupado.png";
                    btnBox8.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "8" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox8.ImageUrl = "img/boxEnMantencion.png";
                    btnBox8.Enabled = false;
                }

                if (ds["id_box"].ToString() == "8")
                {
                    lblTipo8.Text = ds["nombre_tipo"].ToString();
                    lblTamano8.Text = ds["tamano"].ToString();
                    lblIdBox8.Text = ds["id_box"].ToString();
                }

                //Box 9
                if (ds["id_box"].ToString() == "9" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox9.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "9" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox9.ImageUrl = "img/boxOcupado.png";
                    btnBox9.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "9" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox9.ImageUrl = "img/boxEnMantencion.png";
                    btnBox9.Enabled = false;
                }

                if (ds["id_box"].ToString() == "9")
                {
                    lblTipo9.Text = ds["nombre_tipo"].ToString();
                    lblTamano9.Text = ds["tamano"].ToString();
                    lblIdBox9.Text = ds["id_box"].ToString();
                }

                //Box 10
                if (ds["id_box"].ToString() == "10" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox10.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "10" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox10.ImageUrl = "img/boxOcupado.png";
                    btnBox10.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "10" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox10.ImageUrl = "img/boxEnMantencion.png";
                    btnBox10.Enabled = false;
                }

                if (ds["id_box"].ToString() == "10")
                {
                    lblTipo10.Text = ds["nombre_tipo"].ToString();
                    lblTamano10.Text = ds["tamano"].ToString();
                    lblIdBox10.Text = ds["id_box"].ToString();
                }

                //Box 11
                if (ds["id_box"].ToString() == "11" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox11.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "11" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox11.ImageUrl = "img/boxOcupado.png";
                    btnBox11.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "11" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox11.ImageUrl = "img/boxEnMantencion.png";
                    btnBox11.Enabled = false;
                }

                if (ds["id_box"].ToString() == "11")
                {
                    lblTipo11.Text = ds["nombre_tipo"].ToString();
                    lblTamano11.Text = ds["tamano"].ToString();
                    lblIdBox11.Text = ds["id_box"].ToString();
                }

                //Box 12
                if (ds["id_box"].ToString() == "12" && ds["estado_id_estado"].ToString() == "1")
                {
                    btnBox12.ImageUrl = "img/boxDisponible.png";
                }
                else if (ds["id_box"].ToString() == "12" && ds["estado_id_estado"].ToString() == "2")
                {
                    btnBox12.ImageUrl = "img/boxOcupado.png";
                    btnBox12.Enabled = false;
                }
                else if (ds["id_box"].ToString() == "12" && ds["estado_id_estado"].ToString() == "3")
                {
                    btnBox12.ImageUrl = "img/boxEnMantencion.png";
                    btnBox12.Enabled = false;
                }

                if (ds["id_box"].ToString() == "12")
                {
                    lblTipo12.Text = ds["nombre_tipo"].ToString();
                    lblTamano12.Text = ds["tamano"].ToString();
                    lblIdBox12.Text = ds["id_box"].ToString();
                }




            }


        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Session["idBox"] = lblId.Text;
            Session["nombre"] = lblNombre.Text;

            
            Page.RegisterStartupScript("script", "<script> window.close() </script>");
            Page.RegisterStartupScript("script", "<script> window.location.href = 'admSesion.aspx' </script>");
            Biblioteca.fx.editarEstadoBox(int.Parse(lblId.Text), 2);
        }


        protected void onOffButton(ImageButton i, bool ac)
        {
            if (btnBox1.ImageUrl == "img/boxDisponible.png")
            {
                btnBox1.Enabled = ac;
            }
            if (btnBox2.ImageUrl == "img/boxDisponible.png")
            {
                btnBox2.Enabled = ac;
            }

            if (btnBox3.ImageUrl == "img/boxDisponible.png")
            {
                btnBox3.Enabled = ac;
            }
            if (btnBox4.ImageUrl == "img/boxDisponible.png")
            {
                btnBox4.Enabled = ac;
            }
            if (btnBox5.ImageUrl == "img/boxDisponible.png")
            {
                btnBox5.Enabled = ac;
            }
            if (btnBox6.ImageUrl == "img/boxDisponible.png")
            {
                btnBox6.Enabled = ac;
            }
            if (btnBox7.ImageUrl == "img/boxDisponible.png")
            {
                btnBox7.Enabled = ac;
            }
            if (btnBox8.ImageUrl == "img/boxDisponible.png")
            {
                btnBox8.Enabled = ac;
            }
            if (btnBox9.ImageUrl == "img/boxDisponible.png")
            {
                btnBox9.Enabled = ac;
            }
            if (btnBox10.ImageUrl == "img/boxDisponible.png")
            {
                btnBox10.Enabled = ac;
            }
            if (btnBox11.ImageUrl == "img/boxDisponible.png")
            {
                btnBox11.Enabled = ac;
            }
            if (btnBox12.ImageUrl == "img/boxDisponible.png")
            {
                btnBox12.Enabled = ac;
            }

            i.Enabled = true;
        }

        protected void accionBoton(ImageButton i)
        {
            if (i.ImageUrl == "img/boxDisponible.png")
            {
                i.ImageUrl = "img/boxOcupado.png";
                onOffButton(i, false);

            }
            else
            {
                i.ImageUrl = "img/boxDisponible.png";
                onOffButton(i, true);
            }
        }

        protected void btnBox1_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox1);
            lblId.Text = lblIdBox1.Text;
            lblNombre.Text = lblTipo1.Text;

        }

        protected void btnBox2_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox2);
            lblId.Text = lblIdBox2.Text;
            lblNombre.Text = lblTipo2.Text;
        }

        protected void btnBox3_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox3);
            lblId.Text = lblIdBox3.Text;
            lblNombre.Text = lblTipo3.Text;
        }

        protected void btnBox4_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox4);
            lblId.Text = lblIdBox4.Text;
            lblNombre.Text = lblTipo4.Text;
        }

        protected void btnBox5_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox5);
            lblId.Text = lblIdBox5.Text;
            lblNombre.Text = lblTipo5.Text;
        }

        protected void btnBox6_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox6);
            lblId.Text = lblIdBox6.Text;
            lblNombre.Text = lblTipo6.Text;
        }

        protected void btnBox7_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox7);
            lblId.Text = lblIdBox7.Text;
            lblNombre.Text = lblTipo7.Text;
        }

        protected void btnBox8_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox8);
            lblId.Text = lblIdBox8.Text;
            lblNombre.Text = lblTipo8.Text;
        }

        protected void btnBox9_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox9);
            lblId.Text = lblIdBox9.Text;
            lblNombre.Text = lblTipo9.Text;

        }

        protected void btnBox10_Click1(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox10);
            lblId.Text = lblIdBox10.Text;
            lblNombre.Text = lblTipo10.Text;

        }

        protected void btnBox11_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox11);
            lblId.Text = lblIdBox11.Text;
            lblNombre.Text = lblTipo11.Text;

        }

        protected void btnBox12_Click(object sender, ImageClickEventArgs e)
        {
            accionBoton(btnBox12);
            lblId.Text = lblIdBox12.Text;
            lblNombre.Text = lblTipo12.Text;
        }






    }
}