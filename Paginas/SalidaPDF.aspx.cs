using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace Paginas
{
    public partial class SalidaPDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOG"] == null)
            {
                Response.Redirect("inicio.aspx");
            }

            DataTable fila;
            if (!String.IsNullOrEmpty((string)Request.QueryString["id"]))
            {
                string ElId = Request.QueryString["id"].ToString();
                fila = Biblioteca.fx.obtenerFichaPaciente(ElId);
                System.Text.StringBuilder Template = new System.Text.StringBuilder();
                Template.Append(ObtenerPlantilla("FichaPaciente.html"));

                if (fila.Rows.Count > 0)
                {
                    DataRow oRow = fila.Rows[0];

                    Template.Replace("#IDSESION#", oRow["id_atencion"].ToString());
                    Template.Replace("#AGENDAMIENTO#", oRow["fecha_agendamiento"].ToString());
                    Template.Replace("#SESION#", oRow["fecha_inicio"].ToString());
                    Template.Replace("#CENTRO#", oRow["NOMBRE_CENTRO"].ToString());
                    Template.Replace("#RUTPACIENTE#", oRow["RUT"].ToString());
                    Template.Replace("#PACIENTE#", oRow["NOMBRE"].ToString());
                    Template.Replace("#FECHA#", oRow["fechaNacimiento"].ToString());
                    Template.Replace("#FONO#", oRow["FONO_PACIENTE"].ToString());
                    Template.Replace("#DIRECCION#", oRow["DIRECCION_PACIENTE"].ToString());
                    Template.Replace("#TRATAMIENTO#", oRow["TRATAMIENTO"].ToString());
                    Template.Replace("#DESCRIPCION#", oRow["DESCRIPCION"].ToString());
                    Template.Replace("#FUNCIONARIO1#", oRow["NOMBRE_FUN"].ToString());
                    Template.Replace("#CARGO1#", oRow["NOMBRE_CARGO"].ToString());
                    Template.Replace("#ETAPA#", oRow["ETAPA"].ToString());
                    //Template.Replace("#EXPFALLA#", oRow["exp_falla"].ToString());

                    DataRow oRow1 = fila.Rows[1];
                    Template.Replace("#FUNCIONARIO2#", oRow1["NOMBRE_FUN"].ToString());
                    Template.Replace("#CARGO2#", oRow1["NOMBRE_CARGO"].ToString());

                    DataRow oRow2 = fila.Rows[2];
                    Template.Replace("#FUNCIONARIO3#", oRow2["NOMBRE_FUN"].ToString());
                    Template.Replace("#CARGO3#", oRow2["NOMBRE_CARGO"].ToString());

                

                    /*GENERANDO PDF------------------------------------------------------------------------------*/
                    //string file = @"C:\tmp2\" + lblFolio.Text + rdoTipo.SelectedValue + ".pdf";
                    string fontpath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "\\fonts\\cour.ttf";

                    using (MemoryStream _MemoryStream = new MemoryStream())
                    {
                        BaseFont bf = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        FontFactory.RegisterDirectory(System.Web.HttpContext.Current.Request.PhysicalApplicationPath, true);
                        FontFactory.Register(fontpath, "Courier New");
                        //FontFactory.RegisterFamily("Courier New", "Courier New", fontpath);

                        string html = Template.ToString();
                        Document document = new Document(PageSize.LETTER, 1, 1, 1, 1);
                        //PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
                        PdfWriter writer = PdfWriter.GetInstance(document, _MemoryStream);

                        document.Open();
                        foreach (IElement E in HTMLWorker.ParseToList(new StringReader(html), new StyleSheet()))
                        {
                            document.Add(E);
                        }
                        document.Close();

                        //guardar certificado---------------------------------------------->                
                        int bytesLenght = Convert.ToInt32(_MemoryStream.ToArray().Length);
                        byte[] bytes = _MemoryStream.ToArray(); //new byte[bytesLenght];
                        //_MemoryStream.Read(bytes, 0, bytesLenght);


                        //----------------------------------------------------------------->

                        Response.ClearContent();
                        Response.ClearHeaders();
                        Response.AppendHeader("content-disposition", "attachment; filename=Comprobante_Sesion" + ElId + ".pdf");
                        HttpContext.Current.Response.BinaryWrite(_MemoryStream.ToArray());
                        Response.End();

                        /*-----------------------------------------------------------------------------------------------*/
                    }
                }
            }
        }

        public static string ObtenerPlantilla(string plantilla)
        {
            StreamReader objReader = new StreamReader(HttpContext.Current.Server.MapPath("./plantillas/" + plantilla));
            string sLine = "";
            string lectura = "";
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    lectura += sLine.ToString();
            }
            objReader.Close();
            return lectura;
        }
    }
}