using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Paginas
{
    public partial class modificarSesion : System.Web.UI.Page
    {
        //static string boxD = "img/boxDisponible.png";
        static string boxO = "img/boxOcupado.png";
        static string boxM = "img/boxEnMantencion.png";

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
            try
            {
                if (!string.IsNullOrEmpty((string)Request.QueryString["id"]))
                {
                    
                    DataTable dt = Biblioteca.fx.obtenerSesionPorId(Request.QueryString["id"]);
                    DataRow ds = dt.Rows[0];
                    lblId.Text = ds["id_atencion"].ToString();
                    Session["idsesion"] = lblId.Text;
                    Session["idTratamiento"] = ds["id_tratamiento"].ToString();
                    DateTime fAgen = DateTime.Parse(ds["fecha_agendamiento"].ToString());
                    lblFecha.Text = fAgen.ToShortDateString();
                    lblPaciente.Text = ds["rut"].ToString() + " " + ds["nombre_paciente"].ToString();
                    lblTratamiento.Text = ds["tratamiento"].ToString();
                    DateTime fechaI;
                    fechaI = DateTime.Parse(ds["fecha_inicio"].ToString());
                    lblFechaInicio.Text = fechaI.ToString();
                    DateTime fechaF;
                    fechaF = DateTime.Parse(ds["fecha_final"].ToString());
                    lblFechaFin.Text = fechaF.ToString();
                    btnInsumo.Attributes.Add("onclick", "javascript:url();");
                    btnPaquete.Attributes.Add("onclick", "javascript:urlPaquete();");
                    
                }

                DataTable dtbox = new DataTable();
                dtbox = Biblioteca.fx.listarBox(Session["idCentro"].ToString());

                foreach (DataRow ds in dtbox.Rows)
                {
                    //Box 1
                    if (ds["id_box"].ToString() == "1" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box1 , boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "1"  && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "1")
                    {
                        lblBox1.Text = "Box : 1 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 2
                    if (ds["id_box"].ToString() == "2" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box2, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "2" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "2")
                    {
                        lblBox2.Text = "Box : 2 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 3
                    if (ds["id_box"].ToString() == "3" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box3, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "3" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "3")
                    {
                        lblBox3.Text = "Box : 3 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 4
                   if (ds["id_box"].ToString() == "4" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box4, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "4" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box4, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "4")
                    {
                        lblBox4.Text = "Box : 4 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 5
                    if (ds["id_box"].ToString() == "5" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box5, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "5" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box5, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "5")
                    {
                        lblBox5.Text = "Box : 5 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 6
                    if (ds["id_box"].ToString() == "6" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box6, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "6" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box6, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "6")
                    {
                        lblBox6.Text = "Box : 6 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 7
                    if (ds["id_box"].ToString() == "7" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box7, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "7" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box7, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "7")
                    {
                        lblBox7.Text = "Box : 7 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 8
                    if (ds["id_box"].ToString() == "8" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box8, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "8" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box8, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "8")
                    {
                        lblBox8.Text = "Box : 8 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();                      
                    }

                    //Box 9
                    if (ds["id_box"].ToString() == "9" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box9, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "9" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box9, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "9")
                    {
                        lblBox9.Text = "Box : 9 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();                      
                    }

                    //Box 10
                   if (ds["id_box"].ToString() == "10" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box10, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "10" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box10, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "10")
                    {
                        lblBox10.Text = "Box : 10 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();                     
                    }

                    //Box 11
                   if (ds["id_box"].ToString() == "11" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box11, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "11" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box11, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "11")
                    {
                        lblBox11.Text = "Box : 11 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();           
                    }

                    //Box 12
                    if (ds["id_box"].ToString() == "12" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box12, boxO,false);
                    }
                    else if (ds["id_box"].ToString() == "12" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box12, boxM,false);
                    }

                    if (ds["id_box"].ToString() == "12")
                    {
                        lblBox12.Text = "Box : 12 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                      
                    }




                    //Edudown Providencia

                    //Box 1
                    if (ds["id_box"].ToString() == "13" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box1, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "13" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "13")
                    {
                        lblBox1.Text = "Box : 1 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 2
                    if (ds["id_box"].ToString() == "14" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box2, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "14" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "14")
                    {
                        lblBox2.Text = "Box : 2 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 3
                    if (ds["id_box"].ToString() == "15" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box3, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "15" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "15")
                    {
                        lblBox3.Text = "Box : 3 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 4
                    if (ds["id_box"].ToString() == "16" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box4, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "16" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box4, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "16")
                    {
                        lblBox4.Text = "Box : 4 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 5
                    if (ds["id_box"].ToString() == "17" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box5, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "17" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box5, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "17")
                    {
                        lblBox5.Text = "Box : 5 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 6
                    if (ds["id_box"].ToString() == "18" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box6, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "18" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box6, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "18")
                    {
                        lblBox6.Text = "Box : 6 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 7
                    if (ds["id_box"].ToString() == "19" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box7, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "19" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box7, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "19")
                    {
                        lblBox7.Text = "Box : 7 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 8
                    if (ds["id_box"].ToString() == "20" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box8, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "20" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box8, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "20")
                    {
                        lblBox8.Text = "Box : 8 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 9
                    if (ds["id_box"].ToString() == "21" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box9, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "21" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box9, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "21")
                    {
                        lblBox9.Text = "Box : 9 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 10
                    if (ds["id_box"].ToString() == "22" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box10, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "22" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box10, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "22")
                    {
                        lblBox10.Text = "Box : 10 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 11
                    if (ds["id_box"].ToString() == "23" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box11, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "23" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box11, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "23")
                    {
                        lblBox11.Text = "Box : 11 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 12
                    if (ds["id_box"].ToString() == "24" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box12, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "24" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box12, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "24")
                    {
                        lblBox12.Text = "Box : 12 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();

                    }


                    //Edudown Providencia

                    //Box 1
                    if (ds["id_box"].ToString() == "25" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box1, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "25" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "25")
                    {
                        lblBox1.Text = "Box : 1 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 2
                    if (ds["id_box"].ToString() == "26" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box2, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "26" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "26")
                    {
                        lblBox2.Text = "Box : 2 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 3
                    if (ds["id_box"].ToString() == "27" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box3, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "27" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "27")
                    {
                        lblBox3.Text = "Box : 3 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 4
                    if (ds["id_box"].ToString() == "28" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box4, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "28" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box4, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "28")
                    {
                        lblBox4.Text = "Box : 4 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 5
                    if (ds["id_box"].ToString() == "29" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box5, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "29" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box5, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "29")
                    {
                        lblBox5.Text = "Box : 5 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 6
                    if (ds["id_box"].ToString() == "30" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box6, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "31" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box6, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "30")
                    {
                        lblBox6.Text = "Box : 6 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 7
                    if (ds["id_box"].ToString() == "31" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box7, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "31" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box7, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "31")
                    {
                        lblBox7.Text = "Box : 7 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 8
                    if (ds["id_box"].ToString() == "32" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box8, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "32" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box8, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "32")
                    {
                        lblBox8.Text = "Box : 8 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 9
                    if (ds["id_box"].ToString() == "33" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box9, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "33" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box9, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "33")
                    {
                        lblBox9.Text = "Box : 9 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 10
                    if (ds["id_box"].ToString() == "34" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box10, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "34" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box10, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "34")
                    {
                        lblBox10.Text = "Box : 10 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 11
                    if (ds["id_box"].ToString() == "35" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box11, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "35" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box11, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "35")
                    {
                        lblBox11.Text = "Box : 11 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 12
                    if (ds["id_box"].ToString() == "36" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box12, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "36" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box12, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "36")
                    {
                        lblBox12.Text = "Box : 12 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();

                    }

                    //Edudown Temuco

                    //Box 1
                    if (ds["id_box"].ToString() == "37" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box1, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "37" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "37")
                    {
                        lblBox1.Text = "Box : 1 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 2
                    if (ds["id_box"].ToString() == "38" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box2, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "38" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "38")
                    {
                        lblBox2.Text = "Box : 2 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 3
                    if (ds["id_box"].ToString() == "39" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box3, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "39" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box1, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "39")
                    {
                        lblBox3.Text = "Box : 3 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 4
                    if (ds["id_box"].ToString() == "40" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box4, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "40" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box4, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "40")
                    {
                        lblBox4.Text = "Box : 4 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 5
                    if (ds["id_box"].ToString() == "41" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box5, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "41" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box5, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "41")
                    {
                        lblBox5.Text = "Box : 5 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 6
                    if (ds["id_box"].ToString() == "42" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box6, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "42" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box6, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "42")
                    {
                        lblBox6.Text = "Box : 6 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 7
                    if (ds["id_box"].ToString() == "43" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box7, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "43" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box7, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "43")
                    {
                        lblBox7.Text = "Box : 7 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 8
                    if (ds["id_box"].ToString() == "44" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box8, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "44" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box8, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "44")
                    {
                        lblBox8.Text = "Box : 8 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 9
                    if (ds["id_box"].ToString() == "45" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box9, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "45" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box9, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "45")
                    {
                        lblBox9.Text = "Box : 9 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 10
                    if (ds["id_box"].ToString() == "46" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box10, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "46" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box10, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "46")
                    {
                        lblBox10.Text = "Box : 10 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 11
                    if (ds["id_box"].ToString() == "47" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box11, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "47" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box11, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "47")
                    {
                        lblBox11.Text = "Box : 11 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();
                    }

                    //Box 12
                    if (ds["id_box"].ToString() == "48" && ds["estado_id_estado"].ToString() == "2")
                    {
                        cambiarColorBox(box12, boxO, false);
                    }
                    else if (ds["id_box"].ToString() == "48" && ds["estado_id_estado"].ToString() == "3")
                    {
                        cambiarColorBox(box12, boxM, false);
                    }

                    if (ds["id_box"].ToString() == "48")
                    {
                        lblBox12.Text = "Box : 12 Tipo : " + ds["nombre_tipo"].ToString() + " Tamaño: " + ds["tamano"].ToString();

                    }


                }

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }



        protected void cambiarColorBox(ImageButton i , string url, bool ac)
        {
            i.ImageUrl = url;
            i.Enabled = ac;
        }

        protected void desactivarBotones()
        {
            box1.Enabled = false;
            box2.Enabled = false;
            box3.Enabled = false;
            box4.Enabled = false;
            box5.Enabled = false;
            box6.Enabled = false;
            box7.Enabled = false;
            box8.Enabled = false;
            box9.Enabled = false;
            box10.Enabled = false;
            box11.Enabled = false;
            box12.Enabled = false;
        }

        protected void box1_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box1, boxO,true);
            lblBox.Text = "1";
        }

        protected void box2_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box2, boxO,true);
            lblBox.Text = "2";
        }

        protected void box3_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box3, boxO,true);
            lblBox.Text = "3";
        }

        protected void box4_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box4, boxO,true);
            lblBox.Text = "4";
        }

        protected void box5_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box5, boxO,true);
            lblBox.Text = "5";
        }

        protected void box6_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box6, boxO,true);
            lblBox.Text = "6";
        }

        protected void box7_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box7, boxO,true);
            lblBox.Text = "7";
        }

        protected void box8_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box8, boxO,true);
            lblBox.Text = "8";
        }

        protected void box9_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box9, boxO,true);
            lblBox.Text = "9";
        }

        protected void box10_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box10, boxO,true);
            lblBox.Text = "10";
        }

        protected void box11_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box11, boxO,true);
            lblBox.Text = "11";
        }

        protected void box12_Click(object sender, ImageClickEventArgs e)
        {
            desactivarBotones();
            cambiarColorBox(box12, boxO,true);
            lblBox.Text = "12";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblBox.Text == "")
                {
                    lblMessage.Text = "Debe seleccionar un box";
                }
                else
                {

                    Biblioteca.Agenda a = new Biblioteca.Agenda();
                    a.IdAtencion = int.Parse(lblId.Text);
                    a.IdBox = int.Parse(lblBox.Text);
                    a.FechaInicio = DateTime.Parse(lblFechaInicio.Text);
                    a.FechaFin = DateTime.Parse(lblFechaFin.Text);
                    a.FechaAgendamiento = DateTime.Parse(lblFecha.Text);
                    a.IdBox = int.Parse(lblBox.Text);
                    Biblioteca.fx.editarEstadoBox(int.Parse(lblBox.Text), 2);
                    Biblioteca.fx.modificarSesion(a);

                    string script = @"<script type='text/javascript'>alert('Sesión modificada exitosamente');</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, false);
                }

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        protected void btnInsumo_Click(object sender, EventArgs e)
        {
            Page.RegisterStartupScript("script", "<script>window.open('insumos.aspx','height=600', 'width=400')</script>");
        }

        protected void btnPaquete_Click(object sender, EventArgs e)
        {
            Page.RegisterStartupScript("script", "<script>window.open('paqueteInsumos.aspx','height=400', 'width=200')</script>");
        }

        protected void btnInsumo_Click1(object sender, EventArgs e)
        {

        }

        


    }
}